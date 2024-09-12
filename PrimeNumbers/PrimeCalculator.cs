namespace PrimeNumbers;

using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

public class PrimeCalculator
{
    public IEnumerable<int> GetPrimes(int number)
    {
        if (number < 2)
            return Array.Empty<int>();

        return GetBySieveOfEratosthenes(number);
    }

    private static int[] GetBySieveOfEratosthenes(int number)
    {
        //https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
        var numbersMap = new Dictionary<int, bool>();

        // if number is not prime set value to true
        for (int i = 2; i < number + 1; i++)
            numbersMap.Add(i, false);

        for (int i = 2; i < number + 1; i++)
        {
            // if is not prime continue
            if (numbersMap[i])
                continue;

            // start from i squared, laser nubers are collected by the way 
            var actionNumber = i;
            var value = i * i;

            // if i squared > number finish
            if (value > number)
                continue;

            // process numbers
            while (value < number + 1)
            {
                numbersMap[value] = true;
                actionNumber++;
                value = i * actionNumber;
            }

        }

        return numbersMap.Where(kvp => kvp.Value == false).Select(i => i.Key).ToArray();
    }
}
