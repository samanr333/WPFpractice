using EFcrud.Command;
using EFcrud.Model;
using EFcrud.Services;
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
        public StudentModel Student { get; set; }
        NotificationClass notificationServices {  get; set; }
        
        public AddCommand addcommand { get; set; }
        public RemoveCommand removecommand { get; set; }
        public ResetCommand resetcommand { get; set; }
        public UpdateCommand updatecommand { get; set; }
        public ObservableCollection<StudentModel> StudentsList { get; set; }
        private StudentModel _selectedStudent;
        public StudentModel SelectedStudent
        {
            get => _selectedStudent;
            set
            {
                if (_selectedStudent != value)
                {
                    _selectedStudent = value;
                    Student.Name = _selectedStudent.Name;
                    Student.RollNo = _selectedStudent.RollNo;
                    Student.Email = _selectedStudent.Email;
                    Student.Id = _selectedStudent.Id;
                    OnPropertyChanged(nameof(SelectedStudent));
                }
            }
        }
        public StudentViewModel()
        {
            StudentsList = new ObservableCollection<StudentModel>();
            Student = new StudentModel();
            dbContext = new AppDbContext();
            addcommand = new AddCommand(this);
            removecommand = new RemoveCommand(this);
            resetcommand = new ResetCommand(this);
            updatecommand = new UpdateCommand(this);
            LoadStudent();
        }
        private void LoadStudent()
        {
            StudentsList = new ObservableCollection<StudentModel>(dbContext.Studenttable);
        }
        // Add details
        public void Add()
        {
            if(!string.IsNullOrWhiteSpace(Student.Name) && !string.IsNullOrWhiteSpace(Student.Email)) 
            {
                StudentModel students = new StudentModel { Name = Student.Name, RollNo = (int)Student.RollNo, Email = Student.Email };
                dbContext.Studenttable.Add(students);
                dbContext.SaveChanges();
                StudentsList.Add(students);
                //MessageBox.Show("Student details added successfully");

                // Add notification
                notificationServices = new NotificationClass();
                notificationServices.ShowAddNotification(Student.Name,Student.Email, Student.RollNo);

            }
            else
            {
                MessageBox.Show("Please enter all fields");
            }
        }

        // Remove details
        public void Remove()
        {
            if (SelectedStudent != null)
            {
                dbContext.Studenttable.Remove(SelectedStudent);
                dbContext.SaveChanges();
                StudentsList.Remove(SelectedStudent);
                MessageBox.Show("Student details removed successfully");
                LoadStudent();
                Reset();
                // Remove notification
                notificationServices = new NotificationClass();
                notificationServices.ShowRemoveNotification();
            }
            else
            {
                MessageBox.Show("Please select a student to remove");
            }
        }
        private StudentModel FindStudentByID(int studentID)
        {
            return StudentsList.FirstOrDefault(student => student.Id == studentID);
        }


        // Reset
        public void Reset()
        {
            Student.Name = string.Empty;    
            Student.Email = string.Empty;
            Student.RollNo = 0;
        }

        //Update List
        public void UpdateList()
        {
            StudentModel student = FindStudentByID(SelectedStudent.Id);
            student.Name = Student.Name;
            student.Email = Student.Email;
            student.RollNo = Student.RollNo;
            dbContext.Studenttable.Update(student);
            dbContext.SaveChanges();
            LoadStudent();
            // Update notification
            notificationServices = new NotificationClass();
            notificationServices.ShowUpdateNotification(Student.Name, Student.Email, Student.RollNo);
            Reset();
            MessageBox.Show("Item Updated Successfully");
        }

        // Notification
   

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
