using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiDesignPatterns.Adapter
{
    interface LightningPhone
    {
        void Recharge();
        void UseLightning();
    }

    interface MicroUsbPhone
    {
        void Recharge();
        void UseMicroUsb();
    }

    class Iphone : LightningPhone
    {
        private bool connector;
        public void UseLightning()
        {
            connector = true;
            Console.WriteLine("Lightning connected");
        }

        public void Recharge()
        {
            if (connector)
            {
                Console.WriteLine("Recharge started");
                Console.WriteLine("Recharge finished");
            }
            else
            {
                Console.WriteLine("Connect Lightning first");
            }
        }
    }

    class Android : MicroUsbPhone
    {
        private bool connector;

        public void UseMicroUsb()
        {
            connector = true;
            Console.WriteLine("MicroUsb connected");
        }

        public void Recharge()
        {
            if (connector)
            {
                Console.WriteLine("Recharge started");
                Console.WriteLine("Recharge finished");
            }
            else
            {
                Console.WriteLine("Connect MicroUsb first");
            }
        }
    }

    /* exposing the target interface while wrapping source object */
    class LightningToMicroUsbAdapter : MicroUsbPhone
    {

        private readonly LightningPhone lightningPhone;

        public LightningToMicroUsbAdapter(LightningPhone lightningPhone)
        {
            this.lightningPhone = lightningPhone;
        }

        public void UseMicroUsb()
        {
            Console.WriteLine("MicroUsb connected");
            lightningPhone.UseLightning();
        }

        public void Recharge()
        {
            lightningPhone.Recharge();
        }
    }

    public class AdapterDemo
    {
        static void rechargeMicroUsbPhone(MicroUsbPhone phone)
        {
            phone.UseMicroUsb();
            phone.Recharge();
        }

        static void rechargeLightningPhone(LightningPhone phone)
        {
            phone.UseLightning();
            phone.Recharge();
        }

        public static void RechargeWithAdapter()
        {
            Android android = new Android();
            Iphone iPhone = new Iphone();

            Console.WriteLine("Recharging android with MicroUsb");
            rechargeMicroUsbPhone(android);

            Console.WriteLine("Recharging iPhone with Lightning");
            rechargeLightningPhone(iPhone);

            Console.WriteLine("Recharging iPhone with MicroUsb");
            var iPhonewithAdapter = new LightningToMicroUsbAdapter(iPhone);
            rechargeMicroUsbPhone(iPhonewithAdapter);
        }
    }
}
