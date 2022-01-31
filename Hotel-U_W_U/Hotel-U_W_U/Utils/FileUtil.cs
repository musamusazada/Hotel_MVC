using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace Hotel_U_W_U.Utils
{
    public class FileUtil
    {
        public static string CreateFile(string folderPath, IFormFile file)
        {
            string fileName = file.FileName;
            var path = Path.Combine(folderPath, "img", fileName);

            FileStream fs = new FileStream(path, FileMode.Create);
            file.CopyTo(fs);
            fs.Close();
            return fileName;
        }

        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
