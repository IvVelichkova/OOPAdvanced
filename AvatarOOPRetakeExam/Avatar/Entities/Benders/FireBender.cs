
public class FireBender:Bender
{
    /// <summary>
    /// HeatAggression – a floating-point number, holding the heatAggression of the Bender.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="power"></param>
    /// 
    private double heatAggression;
    public FireBender(string name, int power, string type) : base(name, power, type)
    {
        this.HeatAggression = heatAggression;
    }

    public double HeatAggression
    {
        get { return this.heatAggression; }
        set { this.heatAggression = value; }
    }
    public override double Role()
    {
        var res = base.Role();
        var result = res * heatAggression;
        return result;

    }
}

