using System;
using System.Collections;
using System.Collections.Generic;

public class Uni<T>
{
    private readonly List<Student> students;

    public Uni()
    {
        this.Students = new List<Student>();
    }

    public List<Student> Students{ get; set; }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    public Student this[int index]
    {
        get { return this.students[index]; }
    }

   
}

