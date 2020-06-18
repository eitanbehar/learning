﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiDesignPatterns
{
    public interface IBike
    {
        string GetDetails();
        double GetPrice();
    }

    public class AluminiumBike : IBike
    {
        public double GetPrice()
        {
            return 100;
        }

        public string GetDetails()
        {
            return "Aluminium Bike";
        }
    }

    public class CarbonBike : IBike
    {
        public double GetPrice()
        {
            return 1000;
        }

        public string GetDetails()
        {
            return "Carbon";
        }
    }


    public abstract class BikeAccessories : IBike
    {
        private readonly IBike _bike;

        public BikeAccessories(IBike bike)
        {
            _bike = bike;
        }

        public virtual double GetPrice()
        {
            return _bike.GetPrice();
        }

        public virtual string GetDetails()
        {
            return _bike.GetDetails();
        }
    }

    public class SecurityPackage : BikeAccessories
    {
        public SecurityPackage(IBike bike):base(bike)
        {

        }

        public override string GetDetails()
        {
            return base.GetDetails() + " + Security Package";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 1;
        }

    }

    public class SportPackage : BikeAccessories
    {
        public SportPackage(IBike bike) : base(bike)
        {

        }

        public override string GetDetails()
        {
            return base.GetDetails() + " + Sport Package";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 10;
        }
    }

    public class BikeShop
    {
        public static void UpgradeBike()
        {
            var basicBike = new AluminiumBike();
            BikeAccessories upgraded = new SportPackage(basicBike);
            upgraded = new SecurityPackage(upgraded);

            Console.WriteLine($"Bike: '{upgraded.GetDetails()}' Cost: {upgraded.GetPrice()}");

        }
    }

}
