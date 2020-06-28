using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAdapter
{
    class PhoneBookList
    {
        private List<PhoneEntry> phoneEntries { get; set; }

        public PhoneBookList()
        {
            // init phone book
            phoneEntries = new List<PhoneEntry>()
            {
                new PhoneEntry(new Person("Juan", "Calle 1"), "050-123-4567"),
                new PhoneEntry(new Person("Juan", "Calle 1"), "050-999-999"),
                new PhoneEntry(new Person("Juan", "Calle 8"), "050-000-0000"),
                new PhoneEntry(new Person("Pedro", "Calle 1"), "050-111-1111")
            };
        }

        public List<PhoneEntry>  GetAllPhoneNumbers()
        {
            return phoneEntries;
        }
    }

    internal class Person
    {
        public string Name { get;  }
        public string Address { get;  }
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }

    internal class PhoneEntry
    {
        public string Number { get; }
        public Person Person { get; }

        public PhoneEntry(Person person, string number)
        {
            Person = person;
            Number = number;
        }
    }
}
