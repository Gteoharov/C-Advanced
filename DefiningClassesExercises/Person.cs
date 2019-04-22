using System;
namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(int age) : this("No name", age)
        {
        }

        public Person() : this("No name", 1)
        {
        }

        public string Name
        {
            get    
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Value of age must be positive integer!");
                }
                
                this.age = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Age}";
        }
    }
}
