
using System.Collections.Generic;
using System.Linq;

public abstract class Race
{

    /// <summary>
    /// length (int), route (string), a prizePool (int), and participants (Collection of Cars), 
    /// </summary>
    private int lenght;

    private string route;

    private int prizePool;

    protected Dictionary<int,Car> participants;
    

    public Race(int lenght,string route,int prizePool)
    {
        this.Route = route;
        this.Lenght = lenght;
        this.PrizePool = prizePool;
        this.participants = new Dictionary<int,Car>();
        
    }

    public int Lenght
    {
        get
        {
            return this.lenght;
        }
        set { this.lenght = value; }
    }

    public string Route
    {
        get { return this.route; }
        set { this.route = value; }
    }

    public int PrizePool
    {
        get { return this.prizePool; }
        set { this.prizePool = value; }
    }

    public void AddParticipant(int id,Car car)
    {
        this.participants.Add(id, car);
    }

    public bool HasParticipants()
    {
        if (this.participants.Count!=0)
        {
            return true;
        }
        return false;
    }
     public abstract string GetPerformance();

    public bool ConteinsCar(int carId)
    {
        if (this.participants.ContainsKey(carId))
        {
            return true;
        }
        return false;
    }
    
    public string StartRace()
    {
        return "";
    }
}

