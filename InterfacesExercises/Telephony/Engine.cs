using System;
using System.Linq;

public class Engine
    {
        public void RUn()
        {
            
            var check = Console.ReadLine();
            
        var input =check.Split(' ');
            //var res = input.Where(x => x.Any(char.IsDigit));
            int countDigit = 0;
            int countLetter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var newString = input[i];
                for (int j = 0; j < newString.Length; j++)
                {
                    if (char.IsDigit(newString[j]))
                    {
                        countDigit++;
                    }
                    if (char.IsLetter(newString[j]))
                    {
                        countLetter++;
                    }
                }
            }
            if (countDigit==0)
            {
                var smartphone = new Smartphone();
                {
                    //smartphone.Broser = c
                }
                //smartphone.Broser = check;
            }
            if (countLetter==0)
            {
                //var number = new Smartphone(check);
                //{
                //    Console.WriteLine(number.Calling(check));
                //}
            }
           
           
        }
    }

