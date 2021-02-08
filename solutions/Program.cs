using System;

namespace solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("Solution201: {0}", solution201.Maskify("122231")));
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            Console.WriteLine(string.Format("Solution203: is 4 prime? = {0}", solution203.IsPrime(primes, 4)));
        }
    }
}