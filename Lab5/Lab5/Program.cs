using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        delegate void Method();
        static void Main(string[] args)
        {
            Method pointer;

            LastTest lasttest = new LastTest("Math", 25, "Kurpol Vlad", "Nikto", 10, 30, 24, "Passed");

            pointer = lasttest.Output_first_test;
            pointer += lasttest.Output_Exam;
            pointer += lasttest.Output_LastExam;
            pointer += lasttest.Output_LastTest;
            pointer();
            Console.ReadKey();
        }
    }
}
