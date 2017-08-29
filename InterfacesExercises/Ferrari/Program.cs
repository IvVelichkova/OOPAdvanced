using System;
public class Program
{
    static void Main(string[] args)
    {
        var driver = Console.ReadLine();
        var ferrari = new Ferrari(driver);
        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }
        Console.WriteLine(ferrari.ToString());
    }
}

