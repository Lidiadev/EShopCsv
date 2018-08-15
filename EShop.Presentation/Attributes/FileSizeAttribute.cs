using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace EShop.Presentation.Attributes
{
    public class FileSizeAttribute : ValidationAttribute
    {
        private const string ERROR_MESSAGE = "Please upload a file that is not empty.";
        private readonly int _fileMinSize;

        public FileSizeAttribute()
        {
            _fileMinSize = 0;
        }

        public FileSizeAttribute(int minSize)
        {
            _fileMinSize = minSize;
        }

        public override bool IsValid(object value)
        {
            if (value == null) return false;

            return (value as IFormFile).Length > _fileMinSize;
        }

        public override string FormatErrorMessage(string name)
            => ERROR_MESSAGE;
    }
}
