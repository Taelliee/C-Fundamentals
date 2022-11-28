using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] person = input.Split();

                string name = person[0];
                string ID = person[1];
                int age = int.Parse(person[2]);

                if (AlreadyExists(peopleList, ID))
                {
                    foreach (Person p in peopleList)
                    {
                        if (ID == p.ID)
                        {
                            p.Name = name;
                            p.Age = age;
                        }
                    }  
                }
                else
                {
                    Person currPerson = new Person(name, ID, age);
                    peopleList.Add(currPerson);
                }
            }

            foreach (Person p in peopleList.OrderBy(x => x.Age))
            {
                Console.WriteLine(p);
            }
        }

        static bool AlreadyExists(List<Person> peopleList, string iD)
        {
            return peopleList.Any(x => x.ID == iD);
        }
    }
    class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}
