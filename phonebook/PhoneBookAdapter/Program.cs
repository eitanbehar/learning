using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAdapter
{
    class Program
    {
        static void Main(string[] args)
        {

            // consumer wants to know all the phone numbers for a person
            PhoneBook phoneBook = new PhoneBook(new PhoneBookListAdapter()); // inject the adapter
            List<string> phoneNumbers = phoneBook.GetPhoneNumbers("Juan", "Calle 1");
            Console.WriteLine(string.Join(",", phoneNumbers));
            _ = Console.ReadLine();

            // use a different adapter - with a different code style
            Console.WriteLine(string.Join(",",
                (new PhoneBook(new PhoneBookFlatAdapter()).GetPhoneNumbers("Juan", "Calle 8"))));
            _ = Console.ReadLine();

        }
    }
}
