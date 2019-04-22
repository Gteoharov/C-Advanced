using System;
using System.Collections.Generic;
using System.Linq;
using DefiningClasses;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> persons = new List<Person>();

        public List<Person> Persons
        {
            get
            {
                return this.persons;
            }

            set
            {
                this.persons = value;
            }
        }

        public void AddMembers(Person member)
        {
            this.Persons.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.persons.OrderByDescending(x => x.Age).FirstOrDefault();
        }
         
        public List<Person> GetPeopleOverThirty()
        {
            return this.Persons.Where(x => x.Age > 30).ToList();
        }
    }
}
