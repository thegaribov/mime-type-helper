using System;

namespace MimeTypeHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mimeType = MimeTypeHelper.Application.Json;
            var extension = MimeTypeHelper.GetExtension(mimeType);
            var resultMimeType = MimeTypeHelper.GetMimeType(extension);

            Console.WriteLine(mimeType);
            Console.WriteLine(extension);
            Console.WriteLine(resultMimeType);
        }
    }
}
