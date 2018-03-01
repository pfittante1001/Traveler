using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the travelers beach guide");
            Console.WriteLine("We specialize in finding you the best beach based on biological");
            Console.WriteLine("Please enter the colors of your eyes");
            string input = Console.ReadLine().ToLower();
            
            Beach pete = new Beach(input);
           
            Console.WriteLine(pete.SwitchValue());
            
            
        }
    }
}
