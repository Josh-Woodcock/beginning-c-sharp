using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane
{
    protected string name { set; get; }
    protected int passengerNumber { set; get; }

    public Plane(string name, int passengerNumber)
    {
        this.name = name;
        this.passengerNumber = passengerNumber;
        Debug.Log("Name: " + name + " " + "Number of passengers: " + passengerNumber); 
    }
}



public class HangGlider : Plane
{
    protected float pilotWeight { get; set; }

    public HangGlider(string name, int passengerNumber, float pilotWeight) : base(name, passengerNumber)
    {
        this.pilotWeight = pilotWeight;
        Debug.Log("Name: " + name + " " + "Number of passengers: " + passengerNumber + " " + "Pilot Weight: " + pilotWeight);
    }
}


public class AirVehicles : MonoBehaviour
{


    void OnDisable()
    {
        HangGlider hangGlider = new HangGlider("Bob", 1, 92.5f);
    }

}



