using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int input01 = 0; int input02 = 0;

            try
            {
                input01 = int.Parse("77");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter Numeric values");

            }


            try
            {
                input02 = int.parse(console.readline());
            }
            catch (exception ex)
            {
                console.writeline("please enter numeric values");

            }




            //if (Console.ReadLine().GetType() == typeof(String))
            //{
            //    Console.WriteLine("Please enter number");
            //}
            //else
            //{
            //    input01 = int.Parse(Console.ReadLine());

            //}

            //if (Console.ReadLine().GetType() == typeof(String))
            //{
            //    Console.WriteLine("Please enter number");
            //}
            //else
            //{
            //    input02 = int.Parse(Console.ReadLine());

            //}
            Console.WriteLine(input01 + input02);
            Console.ReadLine();
        }
    }
}
