using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    string[] info = Console.ReadLine().Split(';').ToArray();
                    var artist = info[0];
                    var song = info[1];
                    var time = info[2].Split(':').Select(int.Parse).ToArray();
                    TimeSpan span1 = TimeSpan.FromMinutes(time[0]);
                    TimeSpan span2 = TimeSpan.FromSeconds(time[1]);
                    TimeSpan span3 = span1.Subtract(span2);
                    Console.WriteLine(span3);
                }
               


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
