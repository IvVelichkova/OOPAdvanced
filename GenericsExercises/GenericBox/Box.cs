using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>:IComparable<Box<T>> where T:IComparable<T>
   
{
    //private T value;
    public Box(T value)
    {
        this.Value = value;
    }
    public T Value { get; private set; }


    public int CompareTo(Box<T> other)
    {
        return this.Value.CompareTo(other.Value);
    }

    public override string ToString()
    {

        return $"{this.Value.GetType().FullName}: {this.Value}";
    }

}

