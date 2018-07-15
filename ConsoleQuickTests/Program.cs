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
            string text = " elkjfs we5161jfw wk wf ";

            Console.WriteLine(Common.RemoveWhiteSpaces(text));
            Console.ReadLine();
        }
    }
}
