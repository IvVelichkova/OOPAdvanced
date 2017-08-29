using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            var uni = new Uni<Student>();
            var goshko = new Student("Goshko");
            var peshko = new Student("Pesho");

            var tosho = new Student("Tosho");

            uni.AddStudent(goshko);
            uni.AddStudent(peshko);
            uni.AddStudent(tosho);



            for (int i = 0; i < uni.Students.Count; i++)
            {
                Console.WriteLine(uni[i]);
            }
        }

        

        //Data<string> myCustomLis = new Data<string>();
        //string inputLine;
        //while ((inputLine = Console.ReadLine()) != "END")
        //{
        //    var tokens = inputLine.Split();
        //    switch (tokens[0])
        //    {
        //        case "Add":
        //            myCustomLis.Add(tokens[1]);
        //            break;
        //        case "Remove":
        //            myCustomLis.Remove(int.Parse(tokens[1]));
        //            break;
        //        case "Contains":
        //            Console.WriteLine(myCustomLis.Contains(tokens[1]));
        //            break;
        //        case "Swap":
        //            myCustomLis.Swap(int.Parse(tokens[1]), int.Parse(tokens[2]));
        //            break;
        //        case "Sort":
        //           myCustomLis= Sorter.Sort(myCustomLis);
        //            break;
        //        case "Greater":
        //            Console.WriteLine(myCustomLis.CountGreaterThan(tokens[1]));
        //            break;
        //        case "Max":
        //            Console.WriteLine(myCustomLis.Max());      
        //            break;
        //        case "Min":
        //            Console.WriteLine(myCustomLis.Min());                       
        //            break;
        //        case "Print":
        //            foreach (var element in myCustomLis)
        //            {
        //                Console.WriteLine(element);
        //            }
        //            break;

        //   }
        // }
    }
}

