using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main(string[] args)
    {


        var team = new Team("NewTeam");
        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine().Split(new [] {" "},StringSplitOptions.RemoveEmptyEntries);
            var person = new Person(input[0], input[1], int.Parse(input[2]), double.Parse(input[3]));
            team.AddPlayer(person);
        }

        //var t=team.ToString();
        //Console.WriteLine(t);
        //Console.WriteLine(team.ReserveTeam.Count);


        //int lines = int.Parse(Console.ReadLine());
        //var persons = new List<Person>();


        //for (int i = 0; i < lines; i++)
        //{
        //    try
        //    {
        //        var cmdArgs = Console.ReadLine().Split();
        //        var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), double.Parse(cmdArgs[3]));
        //        persons.Add(person);
        //    }

        //    catch (ArgumentException ex)
        //    {
        //        Console.WriteLine(ex.Message);

        //    }
        //}

        //var bonus = double.Parse(Console.ReadLine());
        //persons.ForEach(p => p.IncreaseSalary(bonus));
        //persons.ForEach(p => Console.WriteLine(p.ToString()));

    }


}
