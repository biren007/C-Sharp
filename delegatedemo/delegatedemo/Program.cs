using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegatedemo
{
    class bca
    {
        public delegate int dosum(int a,int b);
        public static int sum(int a,int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bca b = new bca();
            b.dosum.sum();
        }
    }
}
