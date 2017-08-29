using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
   public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var minerTask = new Dictionary<string, int>();
            while (input!="Stop")
            {
                int value = int.Parse(Console.ReadLine());
                if (!minerTask.ContainsKey(input))
                {
                    minerTask.Add(input, 0);
                }


                minerTask[input] += value;
                input = Console.ReadLine();
            }


            foreach (var mt in minerTask)
            {
                Console.WriteLine($"{mt.Key} -> {mt.Value}");
            }
           
        }
    }
}
