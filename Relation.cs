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
        public static void ShowRelationship(Person Person1,Person Person2)
        {
            Console.WriteLine();
        }
    }
}
