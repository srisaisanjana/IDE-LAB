using System;
using System.Collections.Generic;
using System.Linq;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            var names = new List<String>{"sanju","Felipe", "Emillia"};
            foreach(var name in names){
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}