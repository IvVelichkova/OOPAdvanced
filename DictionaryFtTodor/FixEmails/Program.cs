using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
   public class Program
    {
        static void Main(string[] args)
        {

           // var input = Console.ReadLine();
            var fix = new Dictionary<string, string>();
            string input;
            while ((input=Console.ReadLine())!= "stop")
            {
                var email = Console.ReadLine().Trim();
                //if (!email.EndsWith(".uk") && !email.EndsWith(".us"))
                //{
                    if (!fix.ContainsKey(input))
                    {
                        fix.Add(input, String.Empty);
                    }
                    fix[input] = email;
            }
            var toRemove = fix.Where(m => m.Value.EndsWith(".uk") || m.Value.EndsWith(".us")).ToDictionary(h=>h.Key,k=>k.Value);
            foreach (var rm in toRemove)
            {
                fix.Remove(rm.Key);
            }
            foreach (var f in fix)
            {
                Console.WriteLine($"{f.Key} - {f.Value}");
            }
        }
    }
}
