using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.NorthwindService;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindServiceClient client = new NorthwindServiceClient();
            var a = client.GetAllEmployees();
            foreach (var VARIABLE in a )
            {
                Console.WriteLine(VARIABLE);
            }

            Console.ReadLine();

        }
    }
}
