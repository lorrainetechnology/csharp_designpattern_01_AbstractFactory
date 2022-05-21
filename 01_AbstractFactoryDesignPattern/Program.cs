using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AbstractFactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConcreteFactory1");
            new Client(new ConcreteFactory1()).ClientMethod();
            Console.WriteLine();
            Console.WriteLine("ConcreteFactory2");
            new Client(new ConcreteFactory2()).ClientMethod();
            Console.ReadLine();
        }
    }
}
