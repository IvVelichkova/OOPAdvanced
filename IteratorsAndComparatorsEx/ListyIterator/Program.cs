using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public enum Seaason { }
    class Program
    {
        static void Main(string[] args)
        {

            Seaason s = Enum.TryParse(Seaason, "Summer");

            var input = Console.ReadLine().Split().ToList();
            if (input.Count == 1)
            {
                throw new Exception("Invalid Operation!");
            }
            else
            {
                var list = new ListyIterator(input.ToArray());
                var currentInput = String.Empty;


                while ((currentInput = Console.ReadLine()) != "END")
                {
                    var current = currentInput.Split().ToArray();
                    switch (current[0])
                    {

                        case "Move":
                            Console.WriteLine(list.MoveNext());

                            break;
                        case "Print":
                            Console.WriteLine(list.Print());
                            break;
                        case "HasNext":
                            list.HasNext();
                            break;
                    }


                }
            }
        }
    }
}
