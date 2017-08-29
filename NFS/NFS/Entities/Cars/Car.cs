
using System.Text;

public abstract class Car
///A basic car has the following properties: a brand (string), a model (string), an yearOfProduction (int), horsepower (int), acceleration (int), suspension (int), and durability (int).

{

    private string brand;
    private string model;
    private int yearOfProduction;
    protected int horsepower;
    private int acceleration;
    protected int suspension;
    private int durability;

    protected Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.horsepower = horsepower;
        this.acceleration = acceleration;
        this.suspension = suspension;
        this.durability = durability;

    }
    public string Brand { get { return this.brand; } }
    public string Model { get { return this.model; } }
    public abstract void Tune(int tuneIndex, string addOn);
    public int HorsePower
    {
        get
        {
            return this.horsepower;
        }
    }
    public int Acceleration
    {
        get
        {
            return this.acceleration;
        }
    }
    public int Suspension
    {
        get
        {
            return this.suspension;
        }
    }
    public int Durability
    {
        get
        {
            return this.durability;
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{brand} {model} {yearOfProduction}");
        sb.AppendLine($"{horsepower} HP, 100 m/h in {acceleration} s");
        sb.AppendLine($"{suspension} Suspension force, {durability} Durability");
        return sb.ToString();
    }

    public int OverallPerformance()
    {
        return (this.horsepower / this.acceleration) + (this.suspension + this.durability);

    }

    public int EnginePerformance()
    {
        return (this.horsepower / this.acceleration);
    }

    public int SuspensionPerformance()
    {
        return (this.suspension + this.durability);
    }

}

