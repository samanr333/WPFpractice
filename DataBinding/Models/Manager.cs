using System.Collections.ObjectModel;

namespace DataBinding.Models
{
    public class Manager
    {
        public static ObservableCollection<Person> Persons = new ObservableCollection<Person>() { new Person { Name = "Bibek Parajuli", Address = "Bhaktapur", Number = 9866442008 }, new Person { Name = "Sachin Khatri", Address = "Kathmandu", Number = 9860673427 }, new Person { Name = "Saman Raut", Address = "Kathmandu", Number = 9816763435} };
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
