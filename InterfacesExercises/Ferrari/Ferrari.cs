using System;
using System.Text;

public class Ferrari : ICar
{
    private const string model = "488-Spider";
    private string driver;

    public Ferrari(string driver)
    {
        this.Model = model;
        this.Driver = driver;
    }
    public string Model { get; private set; }

    public string Driver { get; private set; }


    public string Breaks()
    {
        return "Brakes!";
    }

    public string PushTheGas()
    {
        return "Zadu6avam sA!";
    }
    public override string ToString()
    {
        //<model>/<brakes>/<gas pedal>/<driver's name>
        var sb = new StringBuilder();

        sb.Append($"{this.Model}/{this.Breaks()}/{this.PushTheGas()}/{this.Driver}");
        return sb.ToString();
    }
}

