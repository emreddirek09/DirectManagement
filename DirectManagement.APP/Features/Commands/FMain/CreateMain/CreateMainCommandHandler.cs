using AlpataBLL.Constants;
using DirectManagement.APP.Repositories.Mains;
using DirectManagement.APP.Repositories.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Features.Commands.FMain.CreateMain
{
    public class CreateMainCommandHandler : IRequestHandler<CreateMainCommandRequest, CreateMainCommandResponse>
    {
        readonly IMainWriteRepository _mainWriteRepository;

        public CreateMainCommandHandler(IMainWriteRepository mainWriteRepository)
        {
            _mainWriteRepository = mainWriteRepository;
        }

        public async Task<CreateMainCommandResponse> Handle(CreateMainCommandRequest request, CancellationToken cancellationToken)
        {

            try
            {
                var res = await _mainWriteRepository.AddAsync(new DOMAIN.Main
                {
                    CompanyName = request.CompanyName,
                    CompanyNo = request.CompanyNo,
                    SiteTitle = request.SiteTitle,
                    WebLink = request.WebLink
                });
                if (res == true)
                {
                    await _mainWriteRepository.SaveAsync();
                    return new CreateMainCommandResponse
                    {
                        Success = true,
                        Message = Messages.RegisterSuccess
                    };
                }
            }
            catch (Exception ex)
            {

                return new CreateMainCommandResponse
                {
                    Success = false,
                    Message = ex.Message.Trim().ToString()
                };
            }
            return new CreateMainCommandResponse
            {
                Success = false,
                Message = Messages.RegisterFailed
            }; 
        }
    }
}
