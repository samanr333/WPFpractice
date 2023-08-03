using System.Collections.ObjectModel;

namespace DataBinding.Models
{
    public class Manager
    {
        public static ObservableCollection<Person> Persons = new ObservableCollection<Person>() { new Person { Name = "Bibek Parajuli", Address = "Bhaktapur", Number = 9866442008, Salary = 20000 }, new Person { Name = "Sachin Khatri", Address = "Kathmandu", Number = 9860673427, Salary = 25000 }, new Person { Name = "Saman Raut", Address = "Kathmandu", Number = 9816763435, Salary = 22000 } };
        public static ObservableCollection<Person> GetPeople()
        {
            return Persons;
        }
        public static void AddPerson(Person person)
        {
            Persons.Add(person);
        }
    }
}
