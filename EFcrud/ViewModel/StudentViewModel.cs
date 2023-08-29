using EFcrud;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows;
using Validation.Command;
using Validation.Model;

namespace Validation.ViewModel
{
    public class StudentViewModel
    {
        public string? Error => null;
        public string? Name { get; set; }
        public int? RollNo { get; set; }
        public string? Email { get; set; }
        public AppDbContext dbContext;
        public RelayCommand relaycommand { get; set; }
        public ObservableCollection<StudentModel> students { get; set; }
        public StudentViewModel()
        {
            students = new ObservableCollection<StudentModel>();
            dbContext = new AppDbContext();
            relaycommand = new RelayCommand(this);
            LoadStudent();
        }
        private void LoadStudent()
        {
            students = new ObservableCollection<StudentModel>(dbContext.Studenttable);
        }

        public void OnExecute()
        {
            StudentModel student = new StudentModel { Name = Name, RollNo = (int)RollNo, Email = Email};
            dbContext.Studenttable.Add(student);
            dbContext.SaveChanges();
            students.Add(student);
            
        }
    }
}
