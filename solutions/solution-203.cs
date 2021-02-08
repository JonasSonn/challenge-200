using System;
using System.Collections;

namespace solutions{
    public class solution203{
        static public string IsPrime(int[] primes, int target) {

        Array.Sort(primes);
        return BinarySearch(ref primes, target) ? "Yes" : "No";
        }

        static public bool BinarySearch(ref int[] primesSub, int target){
            int middle = primesSub.Length/2; 
            if(primesSub[middle] == target)
                return true;
            if(primesSub.Length == 1)
                return false;
            if(primesSub[middle] < target){
                int[] subprime = primesSub[middle..];
                return BinarySearch(ref subprime, target);
            } else if(primesSub[middle] > target){
                int[] subprime = primesSub[0..^middle];
                return  BinarySearch(ref subprime, target);
            } else {
                return false;
            }

        }
    }
}