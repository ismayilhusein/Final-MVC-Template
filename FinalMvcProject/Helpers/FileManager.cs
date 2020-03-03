using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Helpers
{
    public class FileManager
    {
        public static string UploadPath = HttpContext.Current.Server.MapPath("~/Upload/");

        public static string Upload(HttpPostedFileBase file, string allowTypes = "image/png|image/jpeg|image/gif", int maxSize = 1024)
        {
            if (file == null)
            {
                throw new NullReferenceException("The file cannot be null");
            }

            if (file.ContentLength / 1024 > maxSize)
            {
                throw new Exception("The size of file can be max 1024KB");
            }

            if (!allowTypes.Split('|').Contains(file.ContentType))
            {
                throw new Exception("The type of file is not acceptable");
            }

            string fileName = Path.Combine(CreatePath(), Guid.NewGuid().ToString() + "-" + file.FileName);
            file.SaveAs(Path.Combine(UploadPath, fileName));

            return fileName;
        }

        public static void Delete(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new NullReferenceException("The filename cannot be null");
            }

            if (!File.Exists(Path.Combine(UploadPath, fileName)))
            {
                throw new Exception("This file does not exist");
            }

            File.Delete(Path.Combine(UploadPath, fileName));
        }

        public static string CreatePath()
        {
            DateTime now = DateTime.Now;

            if (!Directory.Exists(Path.Combine(UploadPath, now.Year.ToString())))
            {
                Directory.CreateDirectory(Path.Combine(UploadPath, now.Year.ToString()));
            }

            if (!Directory.Exists(Path.Combine(UploadPath, now.Year.ToString(), now.Month.ToString())))
            {
                Directory.CreateDirectory(Path.Combine(UploadPath, now.Year.ToString(), now.Month.ToString()));
            }

            return Path.Combine(now.Year.ToString(), now.Month.ToString());
        }
    }
}