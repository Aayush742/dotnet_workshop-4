using System;

namespace Task3;

public class ParameterDemo
{
    public void Increase(ref int number)
    {
        number += 10;
        Console.WriteLine(number);
    }

    public void GetFullName(out string fullname)
    {
        fullname = "munal poudel";
        Console.WriteLine(fullname);
    }

    public int SumAll(params int[] numbers)
    {
        int sum = 0;

        for (int i=0; i<numbers.Length; i++)
        {
            sum +=numbers[i];
        }

        return sum;
    }
}
