
using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    public void Run()
    {
        var input = String.Empty;
        while ((input = Console.ReadLine()) != "Quit")
        {
            var cmd = input.Split();
            ExecuteCmd(cmd);


        }



    }

    private void ExecuteCmd(string[] cmd)
    {
        var nationBuild = new NationsBuilder();

        switch (cmd[0])
        {
            case "Bender":
                string type = cmd[1];
                string name = cmd[2];
                int power = int.Parse(cmd[3]);
                double arg = double.Parse(cmd[4]);
              nationBuild.AssignBender(type,name,power,arg); 
                break;
            case "Monument":
                break;
            case "Status":
                string nationsType = cmd[1];
                Console.WriteLine(nationsType);
                
                break;
            case "War":
                break;
        }
    }
   


}

