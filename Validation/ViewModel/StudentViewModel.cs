using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using Validation.Command;
using Validation.Model;

namespace Validation.ViewModel
{
    public class StudentViewModel
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int? RollNo { get; set; }
        public string? Email { get; set; }
        public RelayCommand relaycommand { get; set; }
        public ObservableCollection<StudentModel> students { get; set; }
        public StudentViewModel()
        {
            students = new ObservableCollection<StudentModel>
            {
                new StudentModel { Name = "Bibek" , Address = "Bhaktapur", RollNo = 25, Email = "parajulibbek@gmail.com"},
                new StudentModel { Name = "Sachin", Address = "Kathmandu", RollNo = 15, Email = "sachinkhatri@gmail.com"},

            };
            relaycommand = new RelayCommand(this);
        }
        public void OnExecute()
        {
            StudentModel student = new StudentModel { Name = Name, Address = Address, RollNo = (int)RollNo, Email = Email };
            students.Add(student);
        }
    }
}
