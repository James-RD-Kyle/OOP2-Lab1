using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> employee = new List<Person>();
            //Add People
            Person employee1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person employee2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person employee3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person employee4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);
            employee.Add(employee1); //Also could put the information straight in here but it would force me to make more loops later
            employee.Add(employee2);
            employee.Add(employee3);
            employee.Add(employee4);

            List<Relation> relationship = new List<Relation>();
            Relation relationship1 = new Relation("Sister");
            Relation relationship2 = new Relation("Brother");
            Relation relationship3 = new Relation("Mother");
            Relation relationship4 = new Relation("Father");
            relationship.Add(relationship1);
            relationship.Add(relationship2);
            relationship.Add(relationship3);
            relationship.Add(relationship4);

            Person.DisplayPersonInfo(employee2);

            Person.ToString(employee3);

            Person.ChangeFavouriteColour(employee1);

            Person.DisplayPersonInfo(employee1);

            Person.GetAgeInTenYears(employee4);

            //Relationship Stuff Goes Here
            int combined_age = 0;
            int youngest_age = 0;
            string youngest_name = "";
            int oldest_age = 0;
            string oldest_name = "";
            int count = 0;
            foreach (Person person in employee)
            {
                combined_age += person.Age;

                if (person.Age < youngest_age || count == 0)
                {
                    youngest_age = (person.Age);
                    youngest_name = (person.FirstName);
                }
                else if (person.Age > oldest_age)
                {
                    oldest_age = (person.Age);
                    oldest_name = (person.FirstName);
                }
                count++;
            }
            int average_age = combined_age / employee.Count;

            Console.WriteLine($"Average age is: {average_age}");

            Console.WriteLine($"The youngest person is: {youngest_name}");

            Console.WriteLine($"The oldest person is: {oldest_name}");

            foreach(Person person in employee)
            {
                if (person.FirstName.StartsWith("M"))
                {
                    Person.ToString(person);
                }
            }
            foreach (Person person in employee)
            {
                string colour = (person.FavouriteColour.ToLower());
                switch (colour)
                {
                    case "blue":
                        Person.ToString(person);
                        break;
                }
            }
        }
    }
}
