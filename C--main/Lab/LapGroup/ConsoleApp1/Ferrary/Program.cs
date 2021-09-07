using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Driver Name: ");
            string driverName = Console.ReadLine();
            Ferrari ferrari = new Ferrari(driverName);
            Console.WriteLine(ferrari.Model + " / " + ferrari.UseBrakes() + " / " + ferrari.PushGasPedal() + " / " + ferrari.Driver);
            Console.ReadKey();
        }
    }
}

