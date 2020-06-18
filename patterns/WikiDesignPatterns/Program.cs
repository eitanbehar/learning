using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WikiDesignPatterns.Adapter;

namespace WikiDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new Facade();
            facade.Operation1();

            AdapterDemo.RechargeWithAdapter();

            BikeShop.UpgradeBike();


        }
    }
}
