using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Person
    {
        public int PersonId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string FavouriteColour {get; set;}
        public int Age {get; set;}
        public bool IsWorking {get; set;}
        public Person(int personId, string firstName, string lastName, string favouriteColour, int age, bool isWorking)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavouriteColour = favouriteColour;
            Age = age;
            IsWorking = isWorking;
        }
        public static void DisplayPersonInfo(Person employee)
        {
            Console.WriteLine($"{employee.PersonId}: {employee.FirstName} {employee.LastName}'s Favourite Color is {employee.FavouriteColour}");
        }
        public static void ChangeFavouriteColour(Person employee)
        {
            employee.FavouriteColour = ("White");
        }
        public static void GetAgeInTenYears(Person employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}'s Age in 10 years is: {employee.Age + 10}");
        }
        public static void ToString(Person employee)
        {
            Console.WriteLine($"PersonId: {employee.PersonId}\nFirstName: {employee.FirstName}\nLastName: {employee.LastName}\nFavouriteColour: {employee.FavouriteColour}\nAge: {employee.Age}\nIsWorking: {employee.IsWorking}");
        }
    }

}
