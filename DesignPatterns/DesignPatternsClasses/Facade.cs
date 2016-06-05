using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatternsClasses
{
    /// <summary>
    /// Name: Facade;
    /// Other name: Glue;
    /// Classification: structural, to objects;
    /// Frequency of use: 5;
    /// </summary>
    class Facade
    {
        SubSystemA subSystemA = new SubSystemA();
        SubSystemB subSystemB = new SubSystemB();
        SubSystemC subSystemC = new SubSystemC();

        public void OperationAB()
        {
            subSystemA.OperationA();
            subSystemB.OperationB();
            Console.WriteLine("OperationAB was done");
        }
        public void OperationBC()
        {
            subSystemB.OperationB();
            subSystemC.OperationC();
            Console.WriteLine("OperationBC was done");
        }
    }

    class SubSystemA
    {
        public void OperationA()
        {
            Console.WriteLine("Sub System A");
        }
    }
    class SubSystemB
    {
        public void OperationB()
        {
            Console.WriteLine("Sub System B");
        }
    }
    class SubSystemC
    {
        public void OperationC()
        {
            Console.WriteLine("Sub System C");
        }
    }
}
