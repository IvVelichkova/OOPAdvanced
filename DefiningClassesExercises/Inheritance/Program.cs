using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            var randomList = new RandomList();
            for (int i = 0; i < 100; i++)
            {
                randomList.Add(i);
            }
            Console.WriteLine(RandomList.RandomElement(randomList));
        }
    }

