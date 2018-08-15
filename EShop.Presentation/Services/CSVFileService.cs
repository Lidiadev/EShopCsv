using AutoMapper;
using LumenWorks.Framework.IO.Csv;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace EShop.Presentation.Services
{
    public class CSVFileService<T> : IFileService<T>
    {
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public CSVFileService(IMapper mapper, ILogger<CSVFileService<T>> logger)
        {
            _mapper = mapper;
            _logger = logger;
        }

        public IList<T> ReadCSVFile(IFormFile file)
        {
            var csvTable = ReadCsvFileAsDataTable(file.OpenReadStream());

            return _mapper.Map<List<DataRow>, List<T>>(new List<DataRow>(csvTable.Rows.OfType<DataRow>()));
        }

        private DataTable ReadCsvFileAsDataTable(Stream inputStream)
        {
            var csvTable = new DataTable();

            _logger.LogInformation("Started reading the csv file.");
            using (var csvReader = new CsvReader(new StreamReader(inputStream), true))
            {
                csvReader.MissingFieldAction = MissingFieldAction.ReplaceByNull;
                csvTable.Load(csvReader);
            }
            _logger.LogInformation("CSV file read.");

            return csvTable;
        }
    }
}
