using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class StartUp

    {
        static void Main(string[] args)
        {


            var accounts = new Dictionary<int, BankAccount>();
            string input;
            while ((input=Console.ReadLine())!="End")
            {
                var cmdArgs = input.Split();
                var command = input[0];
                switch (command)
                {
                case "Create":
                    Create(cmdArgs, accounts);
                    break;
                }
            }

        }

        private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine($"Account already exists");
            }
        }
    }

