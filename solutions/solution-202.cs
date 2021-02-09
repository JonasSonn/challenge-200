
using System;
using System.Collections.Generic;

namespace solutions {
    class solution202
    {
        internal static string ExpressFactors(ulong positiveint)
        {
            if (positiveint == 1)
                return "1 has no prime factors";
            SortedList<ulong, int> primefactors = ExtractPrimeFactors(ref positiveint);
            return CreateFormattedString(primefactors);;
        }

        private static SortedList<ulong, int> ExtractPrimeFactors(ref ulong positiveint)
        {
            SortedList<ulong, int> primefactors = new SortedList<ulong, int>();

            uint divisor = 2;
            while (positiveint != 1)
            {
                if (positiveint % divisor == 0)
                {
                    if (primefactors.ContainsKey(divisor))
                    {
                        primefactors[divisor] = primefactors[divisor] + 1;
                    }
                    else
                    {
                        primefactors.Add(divisor, 1);
                    }
                    positiveint = positiveint / divisor;
                    divisor = 2;
                }
                else
                    divisor++;
            }

            return primefactors;
        }
     
        private static string CreateFormattedString(SortedList<ulong, int> primefactors)
        {
            string expression = "";
            bool notFirst = false;
            foreach (KeyValuePair<ulong, int> PrimeOccurrencePair in primefactors)
            {
                expression = string.Concat(expression, FormatPrimeFactor(PrimeOccurrencePair, notFirst));
                notFirst = true; 
            }
            return expression;
        }

        private static string FormatPrimeFactor(KeyValuePair<ulong, int> PrimeOccurrencePair, bool NotFirst) {
            string pre = "";
            if (NotFirst)
                pre = " x ";

            if (PrimeOccurrencePair.Value > 1)
                        return $"{pre}{PrimeOccurrencePair.Key}^{PrimeOccurrencePair.Value}";
                    else
                        return $"{pre}{PrimeOccurrencePair.Key}"; 
            
        }

    }
}