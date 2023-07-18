using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using CSVWebApp.Models;
using System.Text;



public class DataController : Controller
{
    private readonly EmployeeDbContext _dbContext;

    public DataController(EmployeeDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult DownloadData()
    {
        
        List<EmployeeDetails> data = _dbContext.empdetails.ToList();
        byte[] csvData = GenerateCsv(data);
        return File(csvData, "text/csv", "data.csv");
    }

    private byte[] GenerateCsv(List<EmployeeDetails> data)
    {
        var stringBuilder = new StringBuilder();

        // CSV File headers
        stringBuilder.AppendLine("Id,Name,Dept,Country");

        foreach (var item in data)
        {
            stringBuilder.AppendLine($"{item.Id},{item.Name},{item.Dept},{item.Country}");
        }

        return Encoding.UTF8.GetBytes(stringBuilder.ToString());
    }
}

