using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text.RegularExpressions;
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
                case "RollNo":
                    error = ValidateStudentRollNo();
                    break;
                case "Email":
                    error = ValidateStudentEmail();
                    break;
                
                case "Password":
                    error = ValidateStudentPassword();
                    break;
            }
            return error;

        }

        private string? ValidateStudentPassword()
        {
            if (String.IsNullOrWhiteSpace(Password))
            {
                return "Password cannot be empty";
            }
            return null;
        }

        private string? ValidateStudentEmail()
        {
            Regex emailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?",
                                        RegexOptions.Compiled | RegexOptions.IgnoreCase);
           
            if (string.IsNullOrWhiteSpace(Email))
            {
                return "Student email cannot be empty";
            }
            else if(!string.IsNullOrWhiteSpace(Email))
            {
                bool isMatch = Regex.IsMatch(Email, $"{emailRegex}");
                if(!isMatch)
                {
                    return "Invalid Email";
                }
            }
            return null;
        }

        private string? ValidateStudentRollNo()
        {
            if (string.IsNullOrWhiteSpace(RollNo.ToString()))
            {
                return "Student Roll no cannot be empty";
            }
            return null;
        }

        private string? ValidateStudentName()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return "Student name cannot be empty.";
            }
            return null;
        }
    }
}
