using GraphsAndCharts.Model;
using System.Collections.Generic;
namespace GraphsAndCharts.ViewModel
{
    class PercentageViewModel
    {
        public List<PercentageModel> percentage { get; set; }
        public PercentageViewModel()
        {
            percentage = new List<PercentageModel>
            {
                new PercentageModel { Name = "A" , Value = 83},
                new PercentageModel { Name = "B" , Value = 75},
                new PercentageModel { Name = "C" , Value = 62},
                new PercentageModel { Name = "D" , Value = 68},
                new PercentageModel { Name = "E" , Value = 87},
            };
        }
    }
}
