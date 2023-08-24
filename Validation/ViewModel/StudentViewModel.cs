using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using Validation.Command;
using Validation.Model;

namespace Validation.ViewModel
{
    public class StudentViewModel : IDataErrorInfo
    {
        public string? Name { get; set; }
        public int? RollNo { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public RelayCommand relaycommand { get; set; }
        public ObservableCollection<StudentModel> students { get; set; }
        public StudentViewModel()
        {
            students = new ObservableCollection<StudentModel>();
            relaycommand = new RelayCommand(this);
        }
        public void OnExecute()
        {
            StudentModel student = new StudentModel { Name = Name, RollNo = (int)RollNo, Email = Email, Password = Password };
            students.Add(student);
        }
        public string Error => null;
        public string this[string propertyName]
        {
            get
            {
                return GetValidationError(propertyName);
            }
        }

        private string GetValidationError(string propertyName)
        {
            string error = null;
            switch (propertyName)
            {
                case "Name":
                    error = ValidateStudentName();
                    break;

            }
            return error;

        }
        private string? ValidateStudentName()
        {
            if (String.IsNullOrWhiteSpace(Name))
            {
                return "Student name cannot be empty.";
            }
            return null;
        }
    }
}
