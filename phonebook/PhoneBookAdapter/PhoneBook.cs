using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBookAdapter
{
    internal class PhoneBook
    {
        readonly IPhoneBook myPhoneBook;

        public PhoneBook(IPhoneBook myPhoneBook)
        {
            // IPhoneBook is the "target"
            // Two adapters can be used: ListAdapter, and FlatAdapter
            // Adapter is injected
            this.myPhoneBook = myPhoneBook;
        }

        internal List<string> GetPhoneNumbers(string Name, string Address)
        {
            return myPhoneBook.GetPhoneNumbers(Name, Address);
        }
    }
}