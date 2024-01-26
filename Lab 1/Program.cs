namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create four Person objects
            Person ian = new Person { personID = 1, firstName = "Ian", lastName = "Brooks", favoriteColour = "Red", age = 30, isWorking = true };
            Person gina = new Person { personID = 2, firstName = "Gina", lastName = "James", favoriteColour = "Green", age = 18, isWorking = false };
            Person mike = new Person { personID = 3, firstName = "Mike", lastName = "Briscoe", favoriteColour = "Blue", age = 45, isWorking = true };
            Person mary = new Person { personID = 4, firstName = "Mary", lastName = "Beals", favoriteColour = "Yellow", age = 28, isWorking = true };

            // Display Gina’s information
            Console.WriteLine($"Gina's information: ID={gina.personID}, First Name={gina.firstName}, Last Name={gina.lastName}, Favorite Color={gina.favoriteColour}");

            // Display all of Mike’s information as a list
            Console.WriteLine($"Mike's information: {mike}");

            // Change Ian’s Favorite Colour to white
            ian.ChangeFavoriteColour();
            Console.WriteLine($"After changing color to white: {ian.firstName}'s information: {ian}");

            // Display Mary’s age after ten years
            Console.WriteLine($"Mary's age after ten years: {mary.GetAgeInTenYears()}");

            // Create two Relation Objects
            Relation ginaMaryRelation = new Relation { RelationshipType = "Sisters" };
            ginaMaryRelation.ShowRelationship(gina, mary);

            Relation ianMikeRelation = new Relation { RelationshipType = "Brothers" };
            ianMikeRelation.ShowRelationship(ian, mike);

            // Add all the Person objects to a list
            List<Person> peopleList = new List<Person> { ian, gina, mike, mary };

            // Display average age
            int totalAge = peopleList.Sum(p => p.age);
            double averageAge = (double)totalAge / peopleList.Count;
            Console.WriteLine($"Average age of people: {averageAge}");

            // Display youngest and oldest person
            var youngest = peopleList.OrderBy(p => p.age).First();
            var oldest = peopleList.OrderByDescending(p => p.age).First();
            Console.WriteLine($"Youngest person: {youngest.firstName} {youngest.lastName}, Age: {youngest.age}");
            Console.WriteLine($"Oldest person: {oldest.firstName} {oldest.lastName}, Age: {oldest.age}");

            // Display names of people whose first names start with M
            var MNames = peopleList.Where(p => p.firstName.StartsWith("M")).Select(p => p.firstName);
            Console.WriteLine($"People whose first names start with M: {string.Join(", ", MNames)}");

            // Display person information of the person that likes the colour blue
            var blueLover = peopleList.FirstOrDefault(p => p.favoriteColour.Equals("Blue"));
            if (blueLover != null)
            {
                Console.WriteLine($"Person who likes the color Blue: {blueLover}");
            }
        }
    }
}
