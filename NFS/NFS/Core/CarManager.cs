
using System;
using System.Collections.Generic;
using System.Text;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
    }
    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        if (type == "Performance")
        {
            this.cars.Add(id, new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
        }
        else
        {
            this.cars.Add(id, new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
        }
    }

    public string Check(int id)
    {

        return cars[id].ToString();

    }

    public void Open(int id, string type, int lenght, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual":
                this.races.Add(id, new CasualRace(lenght, route, prizePool));
                break;
            case "Drag":
                this.races.Add(id, new DragRace(lenght, route, prizePool));

                break;
            case "Drift":
                this.races.Add(id, new DriftRace(lenght, route, prizePool));
                break;
        }

    }

    public void Participate(int carId, int raceId)
    {
        if (!this.garage.ContainsCar(carId))
        {
            if (this.races.ContainsKey(raceId))
            {
                this.races[raceId].AddParticipant(carId, this.cars[carId]);
            }
        }
    } 

    public string Start(int Id)
    {
        string ress = String.Empty;
        if (this.races.ContainsKey(Id))
        {
            if (this.races[Id].HasParticipants())
            {
                ress = this.races[Id].GetPerformance();
                this.races.Remove(Id);
                return ress;

            }
        }
        ress = "Cannot start the race with zero participants.";
        return ress;
    }

    public void Park(int id)
    {
        bool IsRacing = false;
        foreach (var race in this.races)
        {
            if (race.Value.ConteinsCar(id))
            {
                IsRacing = true;
                break;
            }
        }
        if (!IsRacing)
        {
            this.garage.AddCar(id);
        }
    }

    public void Unpark(int id)
    {
        if (this.garage.ContainsCar(id))
        {
            this.garage.RemoveCar(id);
        }
    }

    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var car in this.garage)
        {
            this.cars[car].Tune(tuneIndex, addOn);
        }
    }
}

