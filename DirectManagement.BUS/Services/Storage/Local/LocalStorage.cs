using DirectManagement.APP.Abstractions.Storage.Local;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.BUS.Services.Storage.Local
{
    public class LocalStorage : ILocalStorage
    {
        private readonly IWebHostEnvironment _environment;
        public LocalStorage(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public async Task DeleteAsync(string path, string fileName)
             => File.Delete($"{path}\\{fileName}");
        public List<string> GetFiles(string path)
        {
            DirectoryInfo directory = new(path);
            return directory.GetFiles().Select(f => f.Name).ToList();
        }

        public bool HasFile(string path, string fileName)
          =>  File.Exists($"{path}\\{fileName}");

        async Task<bool> CopyFileAsync(string path, IFormFile formFile)
        {
            try
            {
                await using FileStream fileStream = new(path, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);
                await formFile.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<(string fileName, string pathOrContainerName)>> UploadAsync(string path, IFormFileCollection files)
        {
            try
            {
                var uploadPath = Path.Combine(_environment.WebRootPath, path);
                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }
                List<(string fileName, string path)> datas = new();
                foreach (IFormFile file in files)
                {
                    //string fileNewName = await FileRenameAsync(path, file.FileName);
                    bool result = await CopyFileAsync($"{uploadPath}/{file.Name}", file);
                    datas.Add((file.Name, $"{path}/{file.Name}"));
                }

                return datas;
                //todo hata mesajları geri dönüşleri yazılacak
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
