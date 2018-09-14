using FactoryVsStrategy.Data;
using FactoryVsStrategy.Factory;
using FactoryVsStrategy.Strategies;
using System;
using System.Collections.Generic;

namespace FactoryVsStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager pm = new ProductManager();
            pm.PublishAll();
            Console.ReadLine();
        }


    }
}
