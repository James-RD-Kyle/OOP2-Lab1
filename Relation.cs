using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Relation
    {
        public string RelationshipType {get; set;}
        public Relation(string type)
        {
            RelationshipType = type;
        }
        public static void ShowRelationship(Person person1,Person person2)
        {
            Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: ");
        }
    }
}
