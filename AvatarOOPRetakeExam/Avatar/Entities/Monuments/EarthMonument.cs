﻿public class EarthMonument:Monument
{
   
    private int earthAffinity;
    public EarthMonument(string name) : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }

    public int EarthAffinity { get; set; }
}

