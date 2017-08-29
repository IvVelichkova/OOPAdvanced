using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        List<Box<double>> listOfBox = new List<Box<double>>();

        for (int i = 0; i < n; i++)
        {
            Box<double> boxstr = new Box<double>(double.Parse(Console.ReadLine()));
            listOfBox.Add(boxstr);
        }
        var element = double.Parse(Console.ReadLine());
        var result = GreaterElementCount(listOfBox, element);
        Console.WriteLine(result);
    }

    public static int GreaterElementCount<T>(List<Box<T>> listOfBox, T element) where T : IComparable<T>

        => listOfBox.Count(b => b.Value.CompareTo(element) > 0);





}

