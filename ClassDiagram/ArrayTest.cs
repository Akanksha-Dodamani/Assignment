using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    internal class ArrayTest
    {
        static void Main(string[] args)
        {
            string[] cities = { "Mumbai", "Pune", "Banglore", "Chennai" };

            Console.WriteLine("Using FOR loop:");
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine("Cities: " + cities[i]);
            }

            Console.WriteLine("Using FOREACH loop:");
            foreach (string city in cities)
            {
                Console.WriteLine("Cities: " + city);
            }
        }
    }
}
