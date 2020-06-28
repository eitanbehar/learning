using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAdapter
{
    abstract class PhoneBookBase : IPhoneBook
    {
        public Dictionary<string, List<string>> Directory = new Dictionary<string, List<string>>();

        public void AddPhoneNumber(string name, string address, string number)
        {
            var key = name + "_" + address;
            if (Directory.ContainsKey(key))
            {
                Directory[key].Add(number);
            }
            else
            {
                Directory.Add(key, new List<string>() { number });
            }
        }

        public List<string> GetPhoneNumbers(string Name, string Address)
        {
            var key = Name + "_" + Address;
            if (Directory.ContainsKey(key))
            {
                return Directory[key];
            }
            else
            {
                return new List<string>();
            }
        }

        public abstract void LoadAllPhoneNumbers();
    }
}
