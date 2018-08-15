using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace EShop.Presentation.Attributes
{
    public class FileTypeAttribute : ValidationAttribute
    {
        private const string ERROR_MESSAGE = "Please upload a {0} file.";
        private readonly string _fileType;

        public FileTypeAttribute(string fileType)
        {
            _fileType = fileType;
        }

        public override bool IsValid(object value)
        {
            if (value == null) return true;

            string fileExtension = Path.GetExtension((value as IFormFile).FileName).Substring(1);

            return string.Equals(_fileType, fileExtension, StringComparison.OrdinalIgnoreCase);
        }

        public override string FormatErrorMessage(string name)
            => string.Format(ERROR_MESSAGE, _fileType);
    }
}
