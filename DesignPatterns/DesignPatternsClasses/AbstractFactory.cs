using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatternsClasses
{
    /// <summary>
    /// Name: Abstract Factory;
    /// Other name: Kit;
    /// Classification: creational, to objects;
    /// Frequency of use: 5;
    /// </summary>
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
    class Factory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
    class Factory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
    // Product A
    abstract class AbstractProductA
    {
    }
    class ProductA1 : AbstractProductA
    {
    }
    class ProductA2 : AbstractProductA
    {
    }
    // Product B
    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA productA);
    }
    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA productA)
        {
            Console.WriteLine("Product B1 + " + productA.GetType().Name);
        }
    }
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA productA)
        {
            Console.WriteLine("Product B2 + " + productA.GetType().Name);
        }
    }

    class AbstractFactoryClient
    {
        AbstractProductA productA;
        AbstractProductB productB;

        public AbstractFactoryClient(AbstractFactory factory)
        {
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
        }

        public void InteractProducts()
        {
            productB.Interact(productA);
        }
    }
}
