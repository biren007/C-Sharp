using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exceptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 0;
                int j = 5/i;
                
                Console.WriteLine("block of try");
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("error:"+e.Message);
                Console.WriteLine("block of catch");
            }
            finally
            {
                Console.WriteLine("block of finally");
            }
            Console.ReadLine();
        }
    }
}
