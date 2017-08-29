using System;
public static class ArrayCreator
{

    public static T[] Create<T>( int length, T item)
    {
        var res = new T[length];
        return res ;
    }
}

