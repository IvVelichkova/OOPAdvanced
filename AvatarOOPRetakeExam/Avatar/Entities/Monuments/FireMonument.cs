public class FireMonument:Monument
{//FireAffinity – an integer, holding the fireAffinity of the Monument.
    private int fireAffinity;
    public FireMonument(string name) : base(name)
    {
        this.FireAffinity = fireAffinity;
    }

    public int FireAffinity { get; set; }
}

