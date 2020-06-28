using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAdapter
{
    internal interface IPhoneBook
    {
        void AddPhoneNumber(string name, string address, string number);
        List<string> GetPhoneNumbers(string Name, string Address);
        void LoadAllPhoneNumbers();
    }
}
