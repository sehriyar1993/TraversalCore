using BisnessLayer.Abstarct;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.Concrete
{

    public class ExcelManager : IExcelServices
    {
        public byte[] ExcelList<T>(List<T> t) where T : class
        {
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Səhifə");
            workSheet.Cells["A1"].LoadFromCollection(t, true, OfficeOpenXml.Table.TableStyles.Dark10);
            return excel.GetAsByteArray();
        }
    }
}
