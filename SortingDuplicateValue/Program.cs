using System;
using System.Collections.Generic;
using System.Linq;


namespace SortingDuplicateValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ab = new List<dynamic>{ "Dhaka", 50, 0, "100", 12, 45, 50, 78, 12, 0, -1 };

            var nab=new List<dynamic>();

            for (var i = 0; i < ab.Count; i++)
            {
                if (!nab.Contains(ab[i]))
                {
                    nab.Add(ab[i]);
                }
            }

            Console.WriteLine("Actual");
            Console.WriteLine(string.Join(",",ab));
            Console.WriteLine("Custom");
            Console.WriteLine(string.Join(",", nab));
            Console.WriteLine("system");
            Console.WriteLine(string.Join(",", ab.Distinct()));
        }
    }
}
