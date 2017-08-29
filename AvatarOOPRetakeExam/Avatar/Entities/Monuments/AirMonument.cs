public class AirMonument:Monument
{
    /// <summary>
    /// AirAffinity – an integer, holding the airAffinity of the Monument.
    /// </summary>
    /// <param name="name"></param>
    private int airAffinity;
    public AirMonument(string name) : base(name)
    {
        this.AirAffinity = airAffinity;
    }

    public int AirAffinity { get; set; }
}

