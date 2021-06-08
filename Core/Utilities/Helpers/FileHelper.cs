using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers
{
    public static class FileHelper
    {

        public static string CreatePath(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string fileExtension = fileInfo.Extension;
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + " " + DateTime.Now.Day + " " + DateTime.Now.Year + fileExtension;
            string result = $@"\Images\{newPath}";
            return result;

        }

        public static string AddFile(IFormFile file)
        {
            var sourcepath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var fileStream = new FileStream(sourcepath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            var result = CreatePath(file);
            File.Move(sourcepath, @"wwwroot" + result);
            return result;
        }

        public static IResult DeleteFile(string imagePath)
        {
            try
            {
                File.Delete(imagePath);
            }
            catch (Exception ex)
            {
                return new ErrorResult("Dosya silinemedi: " + ex.ToString());
            }

            return new SuccessResult();
        }

        public static string UpdateFile(IFormFile file, string sourcePath)
        {
            var result = CreatePath(file);
            if (sourcePath.Length > 0)
            {
                using (var fileStream = new FileStream(result, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            File.Delete(sourcePath);
            return result;
        }
    }
}