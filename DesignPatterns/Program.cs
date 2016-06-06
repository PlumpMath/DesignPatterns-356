using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.DesignPatternsClasses;

namespace DesignPatterns
{
    class Program
    {
        // Facade
        public static void TestFacade()
        {
            Console.WriteLine("- {0} -", typeof(Facade).Name);
            Console.WriteLine();

            Facade facade = new Facade();
            facade.OperationAB();
            facade.OperationBC();

            Console.WriteLine("***************************************");
            Console.WriteLine();
        }
        // Abctract Factory
        public static void TestAbstractFactory()
        {
            Console.WriteLine("- {0} -", typeof(AbstractFactory).Name);
            Console.WriteLine();

            AbstractFactoryClient client = new AbstractFactoryClient(new Factory1());
            client.InteractProducts();
            client = new AbstractFactoryClient(new Factory2());
            client.InteractProducts();

            Console.WriteLine("***************************************");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            TestFacade();
            TestAbstractFactory();

            Console.ReadLine();
        }
    }
}
