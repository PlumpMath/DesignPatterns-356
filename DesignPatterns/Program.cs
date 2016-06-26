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
        // State
        public static void TestState()
        {
            Console.WriteLine("- {0} -", typeof(State).Name);
            Console.WriteLine();

            ContextWithState context = new ContextWithState(new ConcreteStateA());
            context.Request();
            context.Request();

            Console.WriteLine("***************************************");
            Console.WriteLine();
        }
        // Memento
        public static void TetsMemento()
        {
            Console.WriteLine("- {0} -", typeof(Memento).Name);
            Console.WriteLine();

            Originator originator = new Originator();
            originator.State = "On";
            Console.WriteLine("Current state {0}", originator.State);
            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();
            originator.State = "Off ";
            Console.WriteLine("Changed state {0}", originator.State);
            originator.SetMemento(caretaker.Memento);
            Console.WriteLine("First state {0}", originator.State);

            Console.WriteLine("***************************************");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            TestFacade();
            TestAbstractFactory();
            TestState();
            TetsMemento();

            Console.ReadLine();
        }
    }
}
