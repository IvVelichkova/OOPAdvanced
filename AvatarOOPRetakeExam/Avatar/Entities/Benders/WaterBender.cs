using System;

public class WaterBender : Bender
{
    private double waterClarity;
    public WaterBender(string name, int power, string type) : base(name, power, type)
    {
    }

    public double WaterClarity
    {
        get { return this.waterClarity; }
        set { this.waterClarity = value; }
    }
    public override double Role()
    {
        var res = base.Role();
        var result = res * waterClarity;
        return result;

    }
}
