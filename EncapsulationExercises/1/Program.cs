using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main(string[] args)
    {

        try
        {

            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);


            Console.WriteLine(fields.Count());

            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var box = new Box(lenght, width, height);
            Console.WriteLine(box.SurfaceArea(lenght, width, height));
            Console.WriteLine(box.LateralSFArea(lenght, width, height));
            Console.WriteLine(box.Volume(lenght, width, height));
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            
        }



    }
}

