
using System.Collections;
using System.Collections.Generic;

public class Garage:IEnumerable<int>
{
    private List<int> parking;

    public Garage()
    {
        this.parking = new List<int>();
    }

    public void AddCar(int id)
    {
        parking.Add(id);
    }

    public void RemoveCar(int id)
    {
        parking.Remove(id);
    }

    public bool ContainsCar(int id)
    {
        if (this.parking.Contains(id))
        {
            return true;
        }
        return false;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return this.parking.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

