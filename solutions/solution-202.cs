
using System;
using System.Collections.Generic;

namespace solutions {
    class solution202
    {
        internal static string ExpressFactors(long posint)
        {
            if (posint == 1)
                return "1 has no prime factors";
            SortedList<long, int> primefactors = ExtractPrimeFactors(ref posint);
            return CreateFormattedString(primefactors);;
        }

        private static SortedList<long, int> ExtractPrimeFactors(ref long posint)
        {
            SortedList<long, int> primefactors = new SortedList<long, int>();

            int divisor = 2;
            while (posint != 1)
            {
                if (posint % divisor == 0)
                {
                    if (primefactors.ContainsKey(divisor))
                    {
                        primefactors[divisor] = primefactors[divisor] + 1;
                    }
                    else
                    {
                        primefactors.Add(divisor, 1);
                    }
                    posint = posint / divisor;
                    divisor = 2;
                }
                else
                    divisor++;
            }

            return primefactors;
        }
     
        private static string CreateFormattedString(SortedList<long, int> primefactors)
        {
            string expression = "";
            bool notFirst = false;
            foreach (KeyValuePair<long, int> PrimeOccurrencePair in primefactors)
            {
                expression = string.Concat(expression, FormatPrimeFactor(PrimeOccurrencePair, notFirst));
                notFirst = true; 
            }
            return expression;
        }
        
        private static string FormatPrimeFactor(KeyValuePair<long, int> PrimeOccurrencePair, bool NotFirst) {
            string pre = "";
            if (NotFirst)
                pre = " x ";

            if (PrimeOccurrencePair.Value > 1)
                        return string.Format("{0}{1}^{2}", pre, PrimeOccurrencePair.Key, PrimeOccurrencePair.Value);
                    else
                        return string.Format("{0}{1}", pre, PrimeOccurrencePair.Key);
            
        }

    }
}