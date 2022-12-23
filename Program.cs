using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read n1 and n2 from the user
            Console.Write("Enter n1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter n2: ");
            int n2 = int.Parse(Console.ReadLine());

            // Generate the list of prime numbers between n1 and n2
            for (int i = n1; i <= n2; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}



