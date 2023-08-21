using GraphsAndCharts.Model;
using System.Collections.Generic;

namespace GraphsAndCharts.ViewModel
{
    public class MarksViewModel
    {
        public List<MarksModel> mark { get; set; }
        public MarksViewModel()
        {
            mark = new List<MarksModel>
            {
                new MarksModel { Name = "A" , DSAMarks = 50, CDCMarks = 58 },
                new MarksModel { Name = "B" , DSAMarks = 75, CDCMarks = 59 },
                new MarksModel { Name = "C" , DSAMarks = 62, CDCMarks = 70},
                new MarksModel { Name = "D" , DSAMarks = 68, CDCMarks = 64},
                new MarksModel { Name = "E" , DSAMarks = 87, CDCMarks = 71},
            };
        }
    }
}
