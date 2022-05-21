using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AbstractFactoryDesignPattern
{
    public class Client
    {
        private IAbstractProductA _productA;
        private IAbstractProductB _productB;

        public Client(IAbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }

        public void ClientMethod()
        {
            Console.WriteLine(_productA.ProductDetail());
            Console.WriteLine(_productB.ProductDetail());   
        }
    }
}
