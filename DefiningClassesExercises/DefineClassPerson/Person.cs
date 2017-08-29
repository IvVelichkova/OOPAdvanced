using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClassPerson
{
    public class Person
    {

        public string name;
        public int age;

        public Person() : this("No name", 1)
        {
            
        }

        public Person(int age) : this("No name", age)
        {
            
        }
        public Person(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Invalid name");
            }

            this.name = name;
        }

        public Person(string name, int age) : this(name)
        {
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Age
        {
            get { return this.age; }
        }

    }
}

