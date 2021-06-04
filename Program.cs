using _7_lab;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lr7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator;
            int denumerator;
            Console.WriteLine("Enter numerator and denumerator of nummber1: \n");
            numerator=Convert.ToInt32(Console.ReadLine());
            denumerator = Convert.ToInt32(Console.ReadLine());
            RationalNumber num1 = new RationalNumber(numerator, denumerator);
            Console.WriteLine("Enter numerator and denumerator of nummber2: \n");
            numerator = Convert.ToInt32(Console.ReadLine());
            denumerator = Convert.ToInt32(Console.ReadLine());
            RationalNumber num2 = new RationalNumber(numerator, denumerator);
            RationalNumber[] rationalNumbers = new RationalNumber[] { num1, num2 };

            foreach (RationalNumber i in rationalNumbers)
            {
                RationalNumber.Frac(i);
            }

            Array.Sort(rationalNumbers);
            foreach (RationalNumber i in rationalNumbers)
            {
                RationalNumber.Type(i, "dec");
            }

            Console.WriteLine();

            Console.WriteLine("First>Second:");
            Console.WriteLine( num1 > num2);

            Console.WriteLine("First==Second:");
            Console.WriteLine( num1 == num2);

            Console.WriteLine("Equals : ");
            Console.WriteLine(num1.Equals(num2));
            Console.WriteLine();

            RationalNumber rationalNumber = new RationalNumber();

            Console.WriteLine("number 1 + bumber 2:");
            rationalNumber = num1 + num2;
            RationalNumber.Frac(rationalNumber);
            RationalNumber.Type(rationalNumber, "frac");
            Console.WriteLine();

            Console.WriteLine("number 1 + your int");
            int buf = Convert.ToInt32(Console.ReadLine());
            rationalNumber = num1 + buf;
            RationalNumber.Frac(rationalNumber);
            RationalNumber.Type(rationalNumber, "frac");
            Console.WriteLine();

            Console.WriteLine("number 1 - bumber 2:");
            rationalNumber = num1 - num2;
            RationalNumber.Frac(rationalNumber);
            RationalNumber.Type(rationalNumber, "frac");
            Console.WriteLine();

            Console.WriteLine("number 1 * bumber 2:");
            rationalNumber = num1 * num2;
            RationalNumber.Frac(rationalNumber);
            RationalNumber.Type(rationalNumber, "frac");
            Console.WriteLine();

            Console.WriteLine("number 1 / bumber 2:");
            rationalNumber = num1 / num2;
            RationalNumber.Frac(rationalNumber);
            RationalNumber.Type(rationalNumber, "frac");
            Console.WriteLine();


            //To int
            int buf1;
            double buf2;
            buf1 = num1;
            Console.WriteLine(buf1);
            buf2 = (double)num1;
            Console.WriteLine(buf2 + "\n");

            Console.WriteLine(num1.ToString("dec"));
            Console.WriteLine(num1.ToString("frac"));
            Console.WriteLine();
           RationalNumber num = new RationalNumber();
            Console.WriteLine("Enter nummber like 12/5 : ");
            string str = Console.ReadLine();
            num2 = (RationalNumber)str;
            RationalNumber.Type(num2, "frac");
            Console.WriteLine();
            Console.WriteLine("Enter number like 12/5 convert to float : ");
            string inputStr = Console.ReadLine();
            string[] rationalNumbers1 = inputStr.Split(' ');
            List<RationalNumber> RelNumbers = new List<RationalNumber>();
            RationalNumber.StrC(rationalNumbers1, RelNumbers);


            foreach (RationalNumber i in RelNumbers)
            {
                Console.WriteLine(i.ToString("dec"));
            }
        }
    }
}