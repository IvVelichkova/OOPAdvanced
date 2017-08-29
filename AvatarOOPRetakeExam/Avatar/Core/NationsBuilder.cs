
  using System;
  using System.Collections.Generic;

public class NationsBuilder
{

    public void AssignBender(string type,string name, int power,double param)
    {
        var nation = new Nation();
        switch (type)
        {
            case "Fire":
                nation.Type.Add(new FireBender( name, power,type));
                break;
            case "Air":
                nation.Type.Add(new AirBender(name, power, type));
                break;
            case "Wather":
                nation.Type.Add(new WaterBender(name, power, type));
                break;
            case "Earth":
                nation.Type.Add(new EarthBender(name, power, type));
                break;
        }
    }
   public void AssignMonument(List<string> monumentArgs)
    {
        //TODO: Add some logic here … 
    }
    public string GetStatus(string nationsType)
    {
        
        return ToString();
    }
    public void IssueWar(string nationsType)
    {
        //TODO: Add some logic here … 
    }
   public string GetWarsRecord()
    {
        //TODO: Add some logic here …
        return"";
    }
}

