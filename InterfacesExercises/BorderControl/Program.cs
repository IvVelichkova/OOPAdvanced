using System;
using System.Collections.Generic;
using BorderControl.Entities;
using System.Linq;

public class Program
{
  public  static void Main(string[] args)
    {

        var enters = String.Empty;
        var enter = new List<Enter>();
        var ides = new List<int>();
        while ((enters = Console.ReadLine()) != "End")
        {
            var res = enters.Split(' ');
            

            if (res.Length > 2)
            {
                var name = res[0];
                int age = int.Parse(res[1]);
                int id = int.Parse(res[2]);

                var citizen = new Enter(id);
                enter.Add(citizen);
                ides.Add(id);
            }
            else
            {
                var model = res[0];
                var id = int.Parse(res[1]);
                var robot = new Enter(id);
                enter.Add(robot);
                ides.Add(id);
            }
            enters = Console.ReadLine();
        }
        int check = int.Parse(Console.ReadLine());
        var result =Checked(enter, check);
        foreach (var r in result )
        {
            //Console.WriteLine(r);
        }

    }

    public  List<int> Checked(List<Enter> enter, int check)
    {
        var added = new List<int>();

        foreach (var en in enter)
        {       
            //bool contains = input.Contains("Net");)
            var i = en.Id.ToString();
            
            if (i.Contains(check.ToString()))
            {
                added.Add(en.Id);
            }
        }

        return added;
    }

}







