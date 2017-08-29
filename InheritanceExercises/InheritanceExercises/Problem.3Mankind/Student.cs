using System;



public class Student : Human

{
    private int facultyNumber;
    public Student(string firstName, string lastNAme) : base(firstName, lastNAme)
    {
    }

    public int FacultyNumber
    {
        get { return this.facultyNumber; }
        set
        {
            if (value.ToString().Length<5 || value.ToString().Length > 10)
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this.facultyNumber = value;
        }
    }
}

