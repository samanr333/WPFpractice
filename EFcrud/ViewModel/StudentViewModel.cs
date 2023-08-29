using EFcrud.Command;
using EFcrud.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace EFcrud.ViewModel
{
    public class StudentViewModel:INotifyPropertyChanged
    {
        public AppDbContext dbContext;
        private StudentModel _student { get; set; }
        public StudentModel Student { get => _student;
            set
            {
                if (_student != value)
                {
                    _student = value;
                    OnPropertyChanged(nameof(Student));
                }
            }
        }
        public AddCommand addcommand { get; set; }
        public RemoveCommand removecommand { get; set; }
        public ResetCommand resetcommand { get; set; }
        public ObservableCollection<StudentModel> studentsList { get; set; }
        private StudentModel _selectedStudent;
        public StudentModel SelectedStudent
        {
            get => _selectedStudent;
            set
            {
                if (_selectedStudent != value)
                {
                    _selectedStudent = value;
                    OnPropertyChanged(nameof(SelectedStudent));
                    if (_selectedStudent != null)
                    {
                        Student.Name = _selectedStudent.Name;
                        Student.RollNo = _selectedStudent.RollNo;
                        Student.Email = _selectedStudent.Email;
                        Student.Id = _selectedStudent.Id;
                    }
                }
            }
        }
        public StudentViewModel()
        {
            studentsList = new ObservableCollection<StudentModel>();
            Student = new StudentModel();
            dbContext = new AppDbContext();
            addcommand = new AddCommand(this);
            removecommand = new RemoveCommand(this);
            resetcommand = new ResetCommand(this);
            LoadStudent();
        }
        private void LoadStudent()
        {
            studentsList = new ObservableCollection<StudentModel>(dbContext.Studenttable);
        }
        // Add details
        public void Add()
        {
            if(!string.IsNullOrWhiteSpace(Student.Name) && !string.IsNullOrWhiteSpace(Student.Email)) 
            {
                StudentModel students = new StudentModel { Name = Student.Name, RollNo = (int)Student.RollNo, Email = Student.Email };
                dbContext.Studenttable.Add(students);
                dbContext.SaveChanges();
                studentsList.Add(students);
                MessageBox.Show("Student details added successfully");
            }
            else
            {
                MessageBox.Show("Please enter all fields");
            }
        }

        // Remove details
        public void Remove(Object obj)
        {
            if (SelectedStudent != null)
            {
                
                dbContext.Studenttable.Remove(SelectedStudent);
                dbContext.SaveChanges();
                studentsList.Remove(SelectedStudent);
                MessageBox.Show("Student details removed successfully");

            }
            else
            {
                MessageBox.Show("Please select a student to remove");
            }
        }
        // Find Student By Student Id
        public StudentModel FindStudentByID(int studentID)
        {
            return studentsList.FirstOrDefault<StudentModel>(student => Student.Id == studentID);
        }

        //Reset
        public void Reset()
        {
            Student.Name = string.Empty;
            Student.Email = string.Empty;
            Student.RollNo = 0;
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
