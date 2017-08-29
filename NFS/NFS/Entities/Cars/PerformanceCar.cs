
using System;
using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    private List<string> addons;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) : base(brand, model, yearOfProduction, horsepower+((horsepower*50)/100), acceleration, suspension-((suspension*25)/100), durability)
    {
        this.addons = new List<string>();

    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.horsepower += tuneIndex;
        base.suspension += (tuneIndex * 50) / 100;
        this.addons.Add(addOn);
    }

    public override string ToString()
    {

        StringBuilder sb = new StringBuilder(base.ToString());
        

        if (this.addons.Count > 0)
        {
            sb.AppendLine("Add-ons: " + string.Join(", ", addons));

        }
        else
        {
            sb.AppendLine("Add-ons: None");
        }
        return sb.ToString().Trim();
    }

   
}

