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
            string ptcode = "8100--285";


            Console.WriteLine(CommonPT.IsPostalCodePT(ptcode));
            Console.ReadLine();
        }
    }
}
