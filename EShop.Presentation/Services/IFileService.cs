using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace EShop.Presentation.Services
{
    public interface IFileService<T>
    {
        IList<T> ReadCSVFile(IFormFile file);
    }
}
