using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Threading
{
    class PLinqIntro
    {
        public static void DoSomething()
        {
            List<Person> persons = new List<Person>()
            {
                new Person("pepe"),
                new Person("juan"),
                new Person("pedro"),
                new Person("jose"),
                new Person("pupo"),
                new Person("enrique")
            };


            char token = 'j';
            var jPersons = persons.AsParallel().Where((p) =>
            {
                if (p.Name.Contains(token))
                    return true;
                return false;
            });

            Console.WriteLine("Number of persons with char 'j': " + jPersons.Count());

            var pPersons = persons.AsParallel().Where(NameHasP);
            Console.WriteLine("Number of persons with char 'p': " + pPersons.Count());

        }

        private static bool NameHasP(Person person)
        {
            if (person.Name.Contains("p"))
                return true;
            else
                return false;            
        }
    }

    internal class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
