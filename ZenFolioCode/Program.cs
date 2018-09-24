using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenCode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var input = string.Empty;
            Console.Write("Please enter an input:");
            input =  Console.ReadLine();
            do
            {
                Console.Write("please enter your name: ");
                input =  Console.ReadLine();

            } while (!input.ToLower().Equals("quit"));

            return;

        }
       
    }
}
