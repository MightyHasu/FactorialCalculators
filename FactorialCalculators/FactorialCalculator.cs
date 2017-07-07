﻿using System;
using System.Diagnostics;


namespace FactorialCalculator
{
    class FactorialCalculator
    {

        static void Main(string[] args)
        {
            int result = 1;
            int number = int.Parse(Console.ReadLine());
            Stopwatch watch = new Stopwatch();

            watch.Start();
            for (int i = 0; i < 1000; i++)
            {
                result = CalcFactorialUsingForLoop(number);
            }
            watch.Stop();
            Console.WriteLine("The result using \"For Loop\" is " + result + " and the execution time is " + watch.ElapsedTicks + " thicks");
            Console.WriteLine();

            watch.Reset();

            watch.Start();
            for (int i = 0; i < 1000; i++)
            {
                result = CalcFactorialUsingWhileLoop(number);
            }
            watch.Stop();
            Console.WriteLine("The result using \"While Loop\" is " + result + " and the execution time is " + watch.ElapsedTicks + " thicks");
            Console.WriteLine();

            watch.Reset();

            watch.Start();
            for (int i = 0; i < 1000; i++)
            {
                result = CalcFactorialUsingSwitchCase(number);
            }
            watch.Stop();
            Console.WriteLine("The result using \"Switch case\" is " + result + " and the execution time is " + watch.ElapsedTicks + " thicks");
            Console.WriteLine();

            watch.Reset();

            watch.Start();
            for (int i = 0; i < 1000; i++)
            {
                result = CalcFactorialUsingRecursion(number);
            }
            watch.Stop();
            Console.WriteLine("The result using \"Recursion\" is " + result + " and the execution time is " + watch.ElapsedTicks + " thicks");
            Console.WriteLine();

            watch.Reset();
        }

        //Using "For Loop"
        //The basic way for solving the problem is using "For Loop"
        static int CalcFactorialUsingForLoop(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            int result = number;
            for (int i = (number - 1); i > 0; i--)
            {
                result *= i;
            }
            return result;
        }

        //Using "While Loop"
        //The tests shows that in this example a little faster approach is using "While Loop"
        //One of the differences between the "For Loop" and "While Loop" is that in the For loop you MUST create a new variable, which is not true for the "While Loop"
        //Initializing that extra variable, can slow the execution time
        static int CalcFactorialUsingWhileLoop(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            int result = number;
            while (number > 1)
            {
                number--;
                result *= number;
            }
            return result;
        }

        //Using Recursion
        //Recursion keeps the code short and simple. Whereas iterative approach makes the code longer.
        //Recursion is sometimes slower, sometimes faster than iteration
        static int CalcFactorialUsingRecursion(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            int result = number * CalcFactorialUsingRecursion(number - 1);
            return result;
        }

        //Since no other limitations are mentioned and there are only 10 input options,
        //I have used a switch case function in combination with table result values. 
        //This function is performed for considerably shorter time compared to other methods as no calculations are required.
        static int CalcFactorialUsingSwitchCase(int number)
        {
            switch (number)
            {
                case 0:
                    return 1;
                    break;
                case 1:
                    return 1;
                    break;
                case 2:
                    return 2;
                    break;
                case 3:
                    return 6;
                    break;
                case 4:
                    return 24;
                    break;
                case 5:
                    return 120;
                    break;
                case 6:
                    return 720;
                    break;
                case 7:
                    return 5040;
                    break;
                case 8:
                    return 40320;
                    break;
                case 9:
                    return 362880;
                    break;
                case 10:
                    return 3628800;
                    break;
                default: return 1; break;
            }
        }
    }
}