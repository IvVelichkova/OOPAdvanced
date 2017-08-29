using System;
using System.Text;


/// <summary>
/// Name – a string, holding the name of the Bender.
/// Power – an integer, holding the power of the Bender.
/// </summary>
public abstract class Bender

{
    private string name;
    private int power;
    private string type;

    public Bender(string name, int power, string type)
    {
        this.Name = name;
        this.Power = power;
        this.type = type;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string TypeNation
    {
        get { return this.type; }
        set { this.type = value; }
    }

    public int Power
    {
        get { return this.power; }
        set { this.power = value; }
    }

    public virtual double Role()
    {
        return power;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        //###Air Bender: Yu, Power: 100, Aerial Integrity: 215.68
        //###Air Bender: Muk, Power: 200, Aerial Integrity: 241.24
        var res = Role();
        sb.AppendLine($"{type} Nation");
        sb.AppendLine($"###{type} Bender:{name},Power{power},Aerial Integrity: {Role()}");

        return sb.ToString();
    }
}

