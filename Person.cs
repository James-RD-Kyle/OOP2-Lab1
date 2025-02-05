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
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

}
