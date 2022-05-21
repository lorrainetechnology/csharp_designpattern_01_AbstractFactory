using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AbstractFactoryDesignPattern
{
    public interface IAbstractProductA
    {
        string ProductDetail();
    }

    public class ConcreteProductA1 : IAbstractProductA
    {
        public string ProductDetail()
        {
            return "ProductA1";
        }
    }

    public class ConcreteProductA2 : IAbstractProductA
    {
        public string ProductDetail()
        {
            return "ProductA2";
        }
    }

    public interface IAbstractProductB
    {
        string ProductDetail();
    }

    public class ConcreteProductB1 : IAbstractProductB
    {
        public string ProductDetail()
        {
            return "ProductB1";
        }
    }

    public class ConcreteProductB2 : IAbstractProductB
    {
        public string ProductDetail()
        {
            return "ProductB2";
        }
    }
}
