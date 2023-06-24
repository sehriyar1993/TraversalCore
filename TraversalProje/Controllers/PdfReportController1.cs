using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Controllers
{
    [AllowAnonymous]

    public class PdfReportController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StatikPdfreport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfRaport/" + "pdfsened.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            Paragraph paragraph = new Paragraph("Traversal rezer pdf raport");
            document.Add(paragraph);
            document.Close();
            return File("/PdfRaport/pdfsened.pdf", "application/pdf", "pdfsened.pdf");
        }
        public IActionResult StatikPdfCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfRaport/" + "pdfsenedler.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            PdfPTable pdfTable = new PdfPTable(3);
            pdfTable.AddCell("Qonaq Ad");
            pdfTable.AddCell("Qonaq SoyAd");
            pdfTable.AddCell("Qonaq Pin");

            pdfTable.AddCell("Shahriyar");
            pdfTable.AddCell("Hajiyev");
            pdfTable.AddCell("123456789");

            pdfTable.AddCell("Aygun");
            pdfTable.AddCell("Hajiyev");
            pdfTable.AddCell("123456789");

            pdfTable.AddCell("Aygun1");
            pdfTable.AddCell("Hajiyev");
            pdfTable.AddCell("123456789");
            document.Add(pdfTable);
            document.Close();
            return File("/PdfRaport/pdfsenedler.pdf", "application/pdf", "pdfsenedler.pdf");
        }


    }
}
