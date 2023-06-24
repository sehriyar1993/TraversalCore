using BisnessLayer.Abstarct;
using ClosedXML.Excel;
using DataAcsesslayer.Concrete;
using DocumentFormat.OpenXml.Office2010.Ink;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using TraversalProje.Models;

namespace TraversalProje.Controllers
{
    [AllowAnonymous]

    public class ExelController : Controller
    {
        private readonly IExcelServices _excelServices;

        public ExelController(IExcelServices excelServices)
        {
            _excelServices = excelServices;
        }

        public IActionResult Index()
        {
            return View(); 
        }

        public IActionResult StaticExel()
        {
            return File(_excelServices.ExcelList(DestinationList()), "application/vnd.openxmlformats-officefdocument.spreadsheetml.sheet","yenifile.xlsx");
            //return File(bytes,"application/vnd.openxmlformats-officefdocument.spreadsheetml.sheet","file.xlsx");
        }
        public List<DestinationModel> DestinationList ()
        {
            List<DestinationModel> destinationModel= new List<DestinationModel>();
            using (var c = new Context())
            {
                destinationModel = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    Capacity = x.Capacity,
                    DayNight = x.DayNight,
                    Price = x.Price,
                }).ToList();
            }
            return destinationModel;
        }
        public IActionResult DestinationExelReport()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheets = workbook.Worksheets.Add("Tur Səhifəsi");
                workSheets.Cell(1, 1).Value = "Şəhər";
                workSheets.Cell(1, 2).Value = "Müddət";
                workSheets.Cell(1, 3).Value = "Qiymət";
                workSheets.Cell(1, 4).Value = "Boş Yer";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheets.Cell(rowCount, 1).Value = item.City;
                    workSheets.Cell(rowCount, 1).Value = item.DayNight;
                    workSheets.Cell(rowCount, 2).Value = item.Price;
                    workSheets.Cell(rowCount, 3).Value = item.Capacity;
                    rowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officefdocument.spreadsheetml.sheet", "yenifile.xlsx");

                }
            }
        }

    }
}
