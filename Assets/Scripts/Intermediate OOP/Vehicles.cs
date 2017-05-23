using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Vehicle
{
    public abstract string IncreaseSpeed();
}

class Car : Vehicle
{
    public override string IncreaseSpeed()
    {
        return "VROOM";
    }
}


class Tank : Vehicle
{
    public override string IncreaseSpeed()
    {
        return "RUMBLE";
    }
}

public class Vehicles : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnDisable()
    {
        Vehicle[] vehicles = new Vehicle[] { new Car(), new Tank()};

        foreach (Vehicle vehicle in vehicles)
        {
            Debug.Log(vehicle.IncreaseSpeed());
        }
    }
}
