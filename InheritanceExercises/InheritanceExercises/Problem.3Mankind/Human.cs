using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Human should have first name and last name
public class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastNAme)
    {
        this.FirstName = firstName;
        this.LastName = lastNAme;
    }

    public virtual string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (char.IsLower(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {firstName}");
            }
            if (value.Length < 3)
            {
                throw new ArgumentException($"Expected length at least 4 symbols! Argument: {firstName}");
            }
            this.firstName = value;
        }
    }

    public virtual string LastName
    {
        get { return this.lastName; }
        set
        {
            if (char.IsLower(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {lastName}");
            }
            if (value.Length < 3)
            {
                throw new ArgumentException($"Expected length at least 3 symbols! Argument: {lastName}");
            }
            this.firstName = value;
        }
    }
}

