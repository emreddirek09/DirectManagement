using DirectManagement.APP.Validations;
using DirectManagement.UI.Helpers.ClientHelper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.RateLimiting;
using NToastNotify;
using System.Net;
using System.Text.Json.Serialization;
using System.Threading.RateLimiting;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddRazorPages().AddNToastNotifyNoty(new NotyOptions
{
    ProgressBar = true,
    Timeout = 3000,
});
//builder.Services.AddResponseCompression(); 



builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.Cookie.Name = "DirectAuth";
    options.LoginPath = "/Account/Login";
    options.LogoutPath = new PathString("/Account/LogOut");
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromDays(365);
    options.SlidingExpiration = true;
    options.Cookie.SameSite = SameSiteMode.Lax;
    options.Cookie.HttpOnly = true;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    options.Events = new CookieAuthenticationEvents()
    {
        OnValidatePrincipal = async (context) =>
        {
            await Task.Run(() =>
            {
                var now = DateTimeOffset.UtcNow;
                var timeElapsed = now.Subtract(context.Properties.IssuedUtc!.Value);
                var timeRemaining = context.Properties.ExpiresUtc!.Value.Subtract(now);

                if (timeElapsed > TimeSpan.FromMinutes(15) && timeRemaining > TimeSpan.FromMinutes(15))
                {
                    context.Properties.IssuedUtc = DateTimeOffset.UtcNow;
                    context.Properties.ExpiresUtc = DateTimeOffset.UtcNow.Add(options.ExpireTimeSpan);
                    context.ShouldRenew = true;
                }
            });
        }
    };
});
#region HttpClient
builder.Services
    .AddHttpClient<IDirectClient, DirectClient>()
    .ConfigurePrimaryHttpMessageHandler(() =>
        new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
#endregion

#region Fluent Validation
builder.Services.AddValidatorsFromAssemblyContaining<IFluentValidator>().AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();
#endregion

#region RateLimit

builder.Services.AddRateLimiter(options =>
{
    options.RejectionStatusCode = StatusCodes.Status429TooManyRequests;
    options.AddFixedWindowLimiter("fixed", options =>
    {
        options.PermitLimit = 20;
        options.AutoReplenishment = true;
        options.Window = TimeSpan.FromSeconds(15);
    });

    options.OnRejected = async (context, token) =>
    {
        context.HttpContext.Response.StatusCode = StatusCodes.Status429TooManyRequests;
        if (context.Lease.TryGetMetadata(MetadataName.RetryAfter, out var retryAfter))
        {
            await context.HttpContext.Response.WriteAsync(
                $"Cok fazla istekde bulundunuz. Lutfen {string.Format("{0:H:mm:ss}", new DateTime(retryAfter.Ticks))} saniye sonra tekrar deneyin", cancellationToken: token);
        }
        else
        {
            await context.HttpContext.Response.WriteAsync(
                "Cok fazla istekde bulundunuz. Lutfen sonra tekrar deneyin. ", cancellationToken: token);
        }
    };
});
#endregion
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.UseNToastNotify();
app.Use(async (context, next) =>
{
    await next();
    if (context.Response.StatusCode == (int)HttpStatusCode.NotFound)
    {
        context.Response.Redirect("/PageNotFound");
    }
});
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Register}/{id?}")
    .WithStaticAssets();


app.Run();
