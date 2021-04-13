using System;
using System.Collections.Generic;

namespace Lab4._3
{
    public class Validator
    {
        public static bool CheckInt(string toCheck)
        {
            bool isInt = Int32.TryParse(toCheck, out int result);
            if (isInt)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, that was not a valid number, please try again");
                return false;
            }
        }
    }
    public class Prime
    {
        public static int GetPrime(int n)
        {
            int counter = 0;
            int prime = 0;
            
            

            for (int i = 2; counter <= n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    counter += 1;
                    
                    
                }
                if (counter == n)
                {
                    prime = i;
                    break;
                }
            }
            return prime;
        }
    }


    class Program
    {
        static bool Continue()
        {
            bool valid = false;
            while (!valid)
            {
                Console.Write("\nDo you want to find another prime number? (y/n) ");
                string ans = Console.ReadLine().ToLower();
                if (ans == "y" || ans == "n")
                {
                    valid = true;
                    if (ans == "n")
                    {
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, that was not a valid option. Please try again");
                }
            }
            Console.Clear();
            return false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Let's locate some primes!\n");
            Console.WriteLine("This application will find you any prime, in order, from first prime number on.\n");
            bool done = false;
            while (!done)
            {

                string inputStr = "";
                int input = 0;
                do
                {
                    Console.Write("Which prime number are you looking for? ");
                    inputStr = Console.ReadLine();

                } while (!Validator.CheckInt(inputStr));

                input = Int32.Parse(inputStr);
                Console.WriteLine($"\nThe number {input} prime is {Prime.GetPrime(input)}");

                done = Continue();


            }
        }
    }
}
