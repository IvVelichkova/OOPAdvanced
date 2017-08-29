public class WaterMonument:Monument
{//WaterAffinity – an integer, holding the waterAffinity of the Monument.
    private int waterAffinity;
    public WaterMonument(string name) : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    public int  WaterAffinity { get; set; }
}

