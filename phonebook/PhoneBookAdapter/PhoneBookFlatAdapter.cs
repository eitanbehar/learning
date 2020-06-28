using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAdapter
{
    class PhoneBookFlatAdapter : PhoneBookBase
    {
        public PhoneBookFlatAdapter()
        {
            LoadAllPhoneNumbers();
        }

        public override void LoadAllPhoneNumbers()
        {
            foreach (var phoneNumber in new PhoneBookFlat().GetAll())
                AddPhoneNumber(phoneNumber.Name, phoneNumber.Address, phoneNumber.Number);
        }
    }
}
