using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAdapter
{
    class PhoneBookFlat
    {
        public readonly List<Phone> phones;

        public PhoneBookFlat()
        {
            phones = new List<Phone>
            {
                new Phone("050-123-4567", "Galaxy" , "Juan", "Calle 8"),
                new Phone("050-456-7890", "Iphone" , "Juan", "Calle 8"),
                new Phone("050-000-0000", "Nokia" , "Pedro", "Calle 8"),
                new Phone("050-999-9999", "Galaxy" , "Juan", "Calle 1")
            };
        }

        public List<Phone> GetAll()
        {
            return phones;
        }

    }

    internal class Phone
    {
        public string Number;
        public string Model;
        public string Name;
        public string Address;

        public Phone(string Number, string Model, string Name, string Address)
        {
            this.Number = Number;
            this.Model = Model;
            this.Name = Name;
            this.Address = Address;
        }

       
    }
}
