using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAdapter
{
    class PhoneBookListAdapter : PhoneBookBase
    {
        public PhoneBookListAdapter()
        {
            LoadAllPhoneNumbers();
        }

        public override void LoadAllPhoneNumbers()
        {
            foreach (var phoneNumber in new PhoneBookList().GetAllPhoneNumbers())
                AddPhoneNumber(phoneNumber.Person.Name, phoneNumber.Person.Address, phoneNumber.Number);
        }
    }
}
