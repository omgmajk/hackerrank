using System;

namespace HackerRankPrime
{
    class Program
    {

        static void isPrime(int num)
        {
            bool prime = true;
            if (num == 1) prime = false;
            if (num == 2) prime = true;
            int rootNum = (int)Math.Floor(Math.Sqrt(num));

            for(int i = 2; i <= rootNum; i++)
            {
                if(num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime == true) Console.WriteLine("Prime");
            else Console.WriteLine("Not prime");

        }

        static void Main(string[] args)
        {
            int nums = Int32.Parse(Console.ReadLine());
            int[] primes = new int[nums];
            while(nums-- > 0)
            {
                primes[nums] = Int32.Parse(Console.ReadLine());
            }
            for (int i = primes.Length - 1; i >= 0; i--)
            {
                isPrime(primes[i]);
            }
        }
    }
}
