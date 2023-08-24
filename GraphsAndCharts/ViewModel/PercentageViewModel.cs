using GraphsAndCharts.Model;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace GraphsAndCharts.ViewModel
{
    public class PercentageViewModel
    {
        public ObservableCollection<PercentageModel> percentage { get; set; }
        public PercentageViewModel()
        {
            /*percentage = new List<PercentageModel>
            {
                new PercentageModel { Name = "A" , Value = 83},
                new PercentageModel { Name = "B" , Value = 75},
                new PercentageModel { Name = "C" , Value = 62},
                new PercentageModel { Name = "D" , Value = 68},
                new PercentageModel { Name = "E" , Value = 87},
            };*/
            ReadExcel();
        }
        public void ReadExcel()
        {
            // Retrieving data from excel file
            percentage = new ObservableCollection<PercentageModel>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(@"C:\Users\saman\OneDrive\Desktop\Bajra Trainee\Course\.NET\WpfApp2\GraphsAndCharts\ViewModel\percentage.xlsx")))
            {
                var worksheet = package.Workbook.Worksheets[0];

                for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
                {
                    // Reading value
                    var name = worksheet.Cells[row, 1].Text;
                    var value = Convert.ToInt32(worksheet.Cells[row, 2].Value);

                    percentage.Add(new PercentageModel { Name = name, Value = value });
                }
            }
        }
    }
}
