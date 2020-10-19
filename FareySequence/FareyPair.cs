using System.Runtime.CompilerServices;
using SortAlgorithms;

[assembly: InternalsVisibleTo("FareySequence.Test")]
namespace FareySequence
{
    internal class FareyPair : ISortable
    {
        internal FareyPair(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public int Numerator { get; private set; }

        public int Denominator { get; private set; }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public bool Equals(FareyPair fareyPair)
        {
            return (Numerator == fareyPair.Numerator) && (Denominator == fareyPair.Denominator);
        }

        public float GetSortValue()
        {
            return (float)Numerator / (float)Denominator;
        }
    }
}
