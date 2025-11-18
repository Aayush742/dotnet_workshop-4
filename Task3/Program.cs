using System;
using System.Globalization;
using Task3;

class Program
{
    public static void Main(string[] args)
    {
        ParameterDemo obj = new ParameterDemo();

        int num = 10;
        obj.Increase(ref num);

        string fullname;
        obj.GetFullName(out fullname);

        int[] nums = {1,2,3,34,2};
        int sums = obj.SumAll(nums);
        Console.WriteLine(sums);
    }
}