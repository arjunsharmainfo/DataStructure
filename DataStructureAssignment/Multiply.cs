using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAssignment
{
    class MultiplyNumber
    {

        //static void Main(string[] args)
        //{

        //    ProcessMultiply();
        //}
       
        static void ProcessMultiply()
        {
            Console.WriteLine("Enter 1st number  to multiply:");
            uint firstNumber = 0;
            uint.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Enter 2nd number  to multiply:");
            uint secondNumber = 0;
            uint.TryParse(Console.ReadLine(), out secondNumber);

            if (firstNumber > 0 && secondNumber > 0)
            {
                Console.WriteLine("Factorial of " + firstNumber + " and " + secondNumber + " is " + Multiply(firstNumber, secondNumber));
            }
            else
            {
                Console.WriteLine("Number you have entered is not valid.");
                Console.ReadKey();
                Console.Clear();
                ProcessMultiply();
            }
            Console.WriteLine("Press key to restart.");
            Console.ReadKey();
            Console.Clear();
            ProcessMultiply();
        }

        static uint MultiplySingleDigitNums(uint first, uint second)
        {
            if (first >= 10 || second >= 10)
            {
                throw new InsufficientExecutionStackException();
            }
            return first * second;
        }


        static uint MultiplyBy10(uint num)
        {
            return num * 10;
        }


        static uint Multiply10(uint num, uint i)
        {
            for (int j = 0; j < i; j++)
            {
                num = MultiplyBy10(num);
            }
            return num;
        }

        static uint Multiply(uint first, uint second)
        {

            uint val3 = 0;
            uint result = 0;
            uint result2 = 0;
            uint result3 = 0;
            uint remainder = 0;
            uint answer = 0;
            uint z = 0;


            while (second > 1)
            {

                uint i = 0;
                val3 = first;
                while (val3 > 1)
                {
                    result = remainder + MultiplySingleDigitNums(val3 % 10, second % 10);
                    result3 = result % 10;
                    result2 = result2 + Multiply10(result3, i);
                    remainder = result / 10;
                    val3 = val3 / 10;
                    i++;
                }

                if (remainder > 0)
                {
                    result2 = Multiply10(remainder, i) + result2;
                }
                result2 = Multiply10(result2, z);

                answer = answer + result2;
                result2 = 0;
                remainder = 0;
                second = second / 10;
                z++;
            }

            return answer;
        }
    }
}
