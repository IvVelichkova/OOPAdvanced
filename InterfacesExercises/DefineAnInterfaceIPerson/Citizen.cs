using System;

public class Citizen : IPerson, IBirthable, IIdentifiable
{
    private string name;
    private int age;
    private string birthdate;
    private string id;

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;

    }

    public int Age
    {
        get { return age; }
        private set { age = value; }
    }

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public string Birthdate { get; set; }

    public string Id { get; set; }
}


