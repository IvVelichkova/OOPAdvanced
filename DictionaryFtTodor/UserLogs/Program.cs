using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {

            var logs=new Dictionary<string, Dictionary<string,int>>();
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                var values = input.Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
                string userName = values[2].Replace("user=", "");
                var ip = values[0].Replace("IP=", "");
                if (!logs.ContainsKey(userName))
                {
                    logs.Add(userName, new Dictionary<string, int>());
                   
                }
                if (!logs[userName].ContainsKey(ip))
                {
                    logs[userName].Add(ip, 0);
                }
                logs[userName][ip] += 1;

            }
            
            foreach (var user in logs.OrderBy(n=>n.Key))
            {
                var sb = new StringBuilder();
                sb.AppendLine($"{user.Key}:");
                foreach (var i in user.Value)
                {
                    sb.Append($"{i.Key} => {i.Value}, ");
                   
                }
                string res = sb.ToString().Trim(',', ' ') + ".";

                //sb.Append(".");
                Console.WriteLine(res);
            }
            
        }
    }
}
