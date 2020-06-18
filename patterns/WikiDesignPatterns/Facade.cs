using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiDesignPatterns
{
    class SubsystemA
    {
        public string OperationA1()
        {
            return "Subsystem A, Method A1\n";
        }
        public string OperationA2()
        {
            return "Subsystem A, Method A2\n";
        }
    }

    class SubsystemB
    {
        public string OperationB1()
        {
            return "Subsystem B, Method B1\n";
        }

        public string OperationB2()
        {
            return "Subsystem B, Method B2\n";
        }
    }

    class SubsystemC
    {
        public string OperationC1()
        {
            return "Subsystem C, Method C1\n";
        }

        public string OperationC2()
        {
            return "Subsystem C, Method C2\n";
        }
    }

    public class Facade
    {
        private readonly SubsystemA a = new SubsystemA();
        private readonly SubsystemB b = new SubsystemB();
        private readonly SubsystemC c = new SubsystemC();
        public void Operation1()
        {
            Console.WriteLine("Operation 1\n" +
                a.OperationA1() +
                b.OperationB1() +
                c.OperationC1());
        }
        public void Operation2()
        {
            Console.WriteLine("Operation 2\n" +
                a.OperationA2() +
                b.OperationB2() +
                c.OperationC2());
        }
    }
}
