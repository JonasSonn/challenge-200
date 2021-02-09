using System;
using System.Collections;

namespace solutions{
    public class solution203{
        static public string IsPrime(int[] primes, int target) {

        Array.Sort(primes);
        return BinarySearch(ref primes, target) ? "Yes" : "No";
        }

        static public bool BinarySearch(ref int[] primesSub, int target){
            int middleindex = primesSub.Length/2; 
            if(TargetFound(primesSub[middleindex], target))
                return true;
            if(ListDepleted(primesSub.Length))
                return false;
            if(TargetLargerThanMiddle(primesSub[middleindex], target)){
                int[] subprime = primesSub[middleindex..];
                return BinarySearch(ref subprime, target);
            } 
            else if(TargetSmallerThanMiddle(primesSub[middleindex], target)){
                int[] subprime = primesSub[0..^middleindex];
                return  BinarySearch(ref subprime, target);
            } 
            else {
                return false;
            }

        }

        static private bool TargetFound(int middleval, int target){
            return (middleval == target) ? true : false;
        }

        static private bool ListDepleted(int length){
            return (length == 1) ? true : false;
        }

        static private bool TargetLargerThanMiddle(int middleval, int target){
            return (middleval < target) ? true : false; 
        }
        static private bool TargetSmallerThanMiddle(int middleval, int target){
            return (middleval > target) ? true : false; 
        }


    }
}