using Microsoft.AspNetCore.Http;

namespace Hotel_U_W_U.Utils
{
    public static class FileExtensions
    {
        public static bool isSupported(this IFormFile file, string contentType)
        {
            return file.ContentType.Contains(contentType);
        }
        public static bool IsGreaterThanGivenLength(this IFormFile file, int kb)
        {
            return file.Length > kb * 1000;
        }
    }
}
