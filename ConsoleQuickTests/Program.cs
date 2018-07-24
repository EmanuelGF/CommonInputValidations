using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInputValidations;

namespace ConsoleQuickTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string testValue = "11223355448";

            Console.WriteLine(CommonPT.IsFiscaNumberPT(testValue));
            Console.ReadLine();
        }
    }
}
