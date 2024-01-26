using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Person
    {   
		public int personID;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;

        public void DisplayPersonInfo(int apersonID, string afirstName, string alastName, string afavoriteColour, int age, bool aisWorking)
        {
            personID = apersonID;
            firstName = afirstName;
            lastName = alastName;
            favoriteColour = afavoriteColour;

            Console.WriteLine($"Name= {firstName} {lastName} personId: {personID} Name’s favorite color is {favoriteColour}");
            Console.ReadLine();
        }
        public void ChangeFavoriteColour()
        {
            favoriteColour = "White";
        }

        public int GetAgeInTenYears()
        {
            return age + 10;
        }

        public override string ToString()
        {
            return $"{personID}, {firstName} {lastName}, {favoriteColour}, {age}, {isWorking}";
        }
    }
}
