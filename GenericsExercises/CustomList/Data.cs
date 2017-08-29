using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Data<T> : IData<T>, IEnumerable<T> where T : IComparable<T>
{
    private readonly  IList<T> list;

    public Data() : this(Enumerable.Empty<T>())
    {
    }
    public Data(IEnumerable<T> collection)
    {
        this.list = new List<T>(collection);
    }

    public IList<T> List
    {
        get { return this.list; }
    }


    public void Add(T element)
    {
        this.list.Add(element);
    }

    public T Remove(int index)
    {
        T temp = this.list[index];
        list.RemoveAt(index);
        return temp;
    }

    public bool Contains(T element) => this.list.Contains(element);

    public void Swap(int index1, int index2)
    {
        T temp = this.list[index1];
        this.list[index1] = this.list[index2];
        this.list[index2] = temp;
    }

    public int CountGreaterThan(T element) =>
        this.list.Count(e => e.CompareTo(element) > 0);

    public T Max()
    {
        return list.Max();
    }

    public T Min()
    {
        return list.Min();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this.list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

