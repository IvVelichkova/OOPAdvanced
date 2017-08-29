using System;
using System.Linq;

public  class Sorter
{
    public static Data<T>Sort<T>(Data<T> list)
        where T : IComparable<T>
    {
        var temp = list.List.OrderBy(x => x);
        return new Data<T>(temp);
    }
}
