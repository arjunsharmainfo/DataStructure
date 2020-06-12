using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAssignment
{
    class KartsubaMultiplication
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
                Console.WriteLine("Mulitiplication of " + firstNumber + " and " + secondNumber + " is " + Multiply(firstNumber, secondNumber));
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

        static uint Multiply10(uint num, int i)
        {
            for (int j = 0; j < i; j++)
            {
                num = MultiplyBy10(num);
            }
            return num;
        }

        static uint Multiply(uint first, uint second)
        {

            uint answer = 0;
            uint z1 = 0;
            uint z2 = 0;
            uint z3 = 0;
            uint a = 0;
            uint b = 0;
            uint c = 0;
            uint d = 0;
            uint e = 0;
            int n = 0;

            if (first > 10 && second > 10)
            {
                n = (first.ToString().Length > second.ToString().Length) ? second.ToString().Length / 2 : first.ToString().Length / 2;

                e = Multiply10(10, n - 1);
                a = first / e;
                b = first % e;
                c = second / e;
                d = second % e;

                z1 = Multiply(a, c);
                z2 = Multiply(b, d);
                z3 = Multiply((a + b), (c + d));

                answer = Multiply10(z1, 2 * n) + Multiply10((z3 - z1 - z2), n) + z2;

                return answer;
            }
            else
            {
                return MultiplySingleDigitNums(first, second);
            }
        }
    }
}
