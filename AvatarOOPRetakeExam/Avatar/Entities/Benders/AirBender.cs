using System;

public class AirBender:Bender
{
    private double aerialIntegrity;
    public AirBender(string name, int power,string type) : base(name, power,type)
    {
        this.AerialIntegrity = aerialIntegrity;
        
    }

    public double AerialIntegrity
    {
        get { return this.aerialIntegrity; }
        set { this.aerialIntegrity = value; }
    }

    public override double Role()
    {
        var res = base.Role();
        var result = res * aerialIntegrity;
        return result;

    }
}

