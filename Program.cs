using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float result;

            string anwser;

            Console.WriteLine("Hello there! Calculator app here.");
            Console.WriteLine("Write first number you must");


            num1 = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("Two numbers must there be, no more, no less");

          num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("What calculation you after?");
            Console.WriteLine("+ for addition, - for substraction, * for multiples, / for division");

            anwser = Console.ReadLine();   
            
            if(anwser == "+") 
            {
                result = num1 + num2;
            }

          else if(anwser == "-")
            {
            result = num1 - num2;
            }

            else if(anwser == "*")
            {
                result = num1 * num2;
            }

            else
            { result = num1 / num2;}

            Console.WriteLine("Reslut here is " + result);
            Console.WriteLine("May the math be with you!");
            Console.ReadKey();
        }
    }
}
