using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using SortAlgorithms;

[assembly: InternalsVisibleTo("FareySequence.Test")]
namespace FareySequence
{
    public class FareySequenceCalculator
    {
        public string Execute(int number)
        {
            var result = $"FareySequence is not defined for number {number}";

            if (number > 0)
            {
                var sequence = CalculatePairs(number);
                result = String.Join(", ", sequence.Select(p => p.ToString()).ToArray());
            }

            return result;
        }

        internal List<FareyPair> CalculatePairs(int number)
        {
            var sequence = new List<FareyPair>();

            if (number > 0)
            {
                sequence.Add(new FareyPair(0, 1));
                for (int denominator = 2; denominator <= number; denominator++)
                {
                    for (int numerator = 1; numerator <= number; numerator++)
                    {
                        if ((numerator < denominator) && ((denominator % numerator != 0) || (numerator == 1)) && !HasCommonDivisor(numerator, denominator))
                        {
                            sequence.Add(new FareyPair(numerator, denominator));
                        }
                    }
                }

                sequence.Add(new FareyPair(1, 1));

                var sortAlgorithm = new MergeSort();
                sequence = sortAlgorithm.Sort(sequence.OfType<ISortable>().ToArray()).OfType<FareyPair>().ToList();
            }

            return sequence;
        }

        internal bool HasCommonDivisor(int numerator, int denominator)
        {
            var i = 2;
            var result = false;

            while ((i < numerator - 1) && !result)
            {
                result = (numerator % i == 0) && (denominator % i == 0);
                i++;
            }

            return result;
        }

        internal bool Compare(FareyPair[] expected, FareyPair[] actual)
        {
            var equals = expected.Length == actual.Length;

            var i = 0;
            while (equals && (i < actual.Length))
            {
                equals = equals && actual[i].Equals(expected[i]);
                i++;
            }

            return equals;
        }
    }
}
