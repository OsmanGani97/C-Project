using Osman_1281404.DITests;
using Osman_1281404.Factories;
using Osman_1281404.Models;
using Osman_1281404.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Osman_1281404
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hospital ");
            Console.WriteLine("============================");
            Console.WriteLine("=========DITest1============");
            Console.WriteLine("============================");
            DITest1 d1 = new DITest1(new RepositoryFactoryImpl());
            d1.Run();
            Console.WriteLine("============================");
            Console.WriteLine("=========DITest2============");
            Console.WriteLine("============================");
            Console.WriteLine();
            DITest2 d2 = new DITest2();
            d2.Run(new RepositoryFactoryImpl());
            Console.WriteLine();
            Console.WriteLine("============================");
            Console.WriteLine("=========DITest3============");
            Console.WriteLine("============================");
            IRepositoryFactory factory = new RepositoryFactoryImpl();
            DITest3 d3=new DITest3(factory.GetRepo<Doctor>());
            d3.Run();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================");
            Console.WriteLine("=========DITest4============");
            Console.WriteLine("============================");
            
            DITest4 d4 = new DITest4();
            d4.Run(factory.GetRepo<Patient>());
            Console.ReadLine();
        }
    }
}

