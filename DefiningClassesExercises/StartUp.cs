using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] personsArgs = Console.ReadLine()
                    .Split();

                string name = personsArgs[0];
                int age = int.Parse(personsArgs[1]); 

                Person person = new Person(name, age);
                family.AddMembers(person);
            }

            Person oldest = family.GetOldestMember();

            Console.WriteLine(oldest);

            List<Person> getPeopleOverThirty = family.GetPeopleOverThirty();
            Console.WriteLine(string.Join(Environment.NewLine, getPeopleOverThirty));

            string firstInputYear = Console.ReadLine();
            string secoundInputYear = Console.ReadLine();

            DataModifier dateModifier = new DataModifier();

            var difference = dateModifier.CalculateTheDifference(firstInputYear, secoundInputYear);
            Console.WriteLine(difference);
        }
    }
}
