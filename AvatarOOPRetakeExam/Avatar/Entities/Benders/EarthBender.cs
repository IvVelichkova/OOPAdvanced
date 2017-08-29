class EarthBender:Bender
{
    /// <summary>
    /// GroundSaturation – a floating-point number, holding the groundSaturation of the Bender.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="power"></param>
    private double groundSaturation;
    public EarthBender(string name, int power, string type) : base(name, power, type)
    {
        this.GroundSaturation = groundSaturation;
    }

    public double GroundSaturation
    {
        get { return this.groundSaturation; }
        set { this.groundSaturation = value; }
    }
    public override double Role()
    {
        var res = base.Role();
        var result = res * groundSaturation;
        return result;

    }
}

