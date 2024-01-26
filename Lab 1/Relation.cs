using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Relation
    {
        public string RelationshipType;

        public void ShowRelationship(Person person1, Person person2)
        {
            Console.WriteLine($"{person1.firstName} and {person2.firstName} are {RelationshipType}");
        }
    }
}
