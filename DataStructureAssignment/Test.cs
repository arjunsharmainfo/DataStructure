using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAssignment
{
    class Test
    {
        static int var = 5;
        static int days = 0;

        static void Main(string[] args)
        {

            starprint();
            starprint2();
            starprint3();
            intpatter();
            intpatter2();
            var = 5;
            logic1();
            var = 5;
            logic2();
            var = 0;
            Console.WriteLine(logic3());
            days = 0;
            GetWeekdaysCount(new DateTime(2014, 10, 1), new DateTime(2014, 10, 4));
            Console.WriteLine(days);
            Console.ReadLine();


        }


        static void starprint(int num = 4)
        {

            for (int i = 0; i < num; i++)
            {

                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");

                }

                Console.WriteLine();

            }
        }

        static void intpatter(int num = 20)
        {
            int k = 1;
            int j = 0;
            for (int i = 1; i <= num; i++)
            {

                if (j == k)
                {
                    Console.Write("*");

                    k++;
                    j = 0;
                }
                else
                {

                    Console.Write(i.ToString());
                    j++;
                }

                Console.WriteLine();

            }
        }

        static void intpatter2(int num = 20)
        {
            int k = 1;
            int j = 0;
            for (int i = 1; i <= num; i++)
            {

                Console.WriteLine(i.ToString());
                j++;


                if (j == k)
                {
                    Console.WriteLine("*");

                    k++;
                    j = 0;
                }




            }

            Console.WriteLine();

        }


        static void starprint2(int num = 5)
        {
            int z = 1;
            for (int i = num; i > 0; i--)
            {
                z = 1;
                for (int j = i; j > 0; j--)
                {
                    if (z % 2 == 0)
                        Console.Write("*");
                    else
                        Console.Write("o");

                    z++;
                }

                Console.WriteLine();
            }

        }
        static void starprint3(int num = 5)
        {

            for (int i = num; i > 0; i--)
            {

                for (int j = i; j > 0; j--)
                {
                    if (j % 2 == 0)
                        Console.Write("*");
                    else
                        Console.Write("o");


                }

                Console.WriteLine();
            }
        }

        static void logic1()
        {

            Console.Write(var--);

            if (var > 0)
            {
                logic1();
            }
            else
            { Console.WriteLine(); }


        }

        static void logic2()
        {

            Console.Write(--var);

            if (var > 0)
            {
                logic2();
            }

            else
            { Console.WriteLine(); }


        }

        static string logic3()
        {
            return ++var <= 100 ? (var % 3 == 0 && var % 5 == 0 ? var + " : xy " + logic3() : (var % 3 == 0 ? var + " : x " + logic3() : (var % 5 == 0 ? var + " : y " + logic3() : var + " : z " + logic3()))) : "";
        }


        static void GetWeekdaysCount(DateTime fromDate, DateTime toDate)
        {

            if (fromDate.Date != toDate.Date)
            {
                if (fromDate.DayOfWeek != DayOfWeek.Sunday && fromDate.DayOfWeek != DayOfWeek.Saturday)
                {

                    days++;

                }
                GetWeekdaysCount(fromDate.Date.AddDays(1), toDate);
            }
        }
    }
}
