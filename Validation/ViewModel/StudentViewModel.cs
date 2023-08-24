using System.Collections.Generic;
using Validation.Model;

namespace Validation.ViewModel
{
    public class StudentViewModel
    {
        public List<StudentModel> students { get; set; }
        public StudentViewModel()
        {
            students = new List<StudentModel>
            {
                new StudentModel { Name = "Bibek" , Address = "Bhaktapur", RollNo = 25, Email = "parajulibbek@gmail.com"},
                new StudentModel { Name = "Sachin", Address = "Kathmandu", RollNo = 15, Email = "sachinkhatri@gmail.com"},

            };
        }
    }
}
