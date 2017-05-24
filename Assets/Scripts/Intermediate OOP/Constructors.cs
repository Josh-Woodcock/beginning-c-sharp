using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport
{
    protected string name { set; get; }
    public Transport(string name)
    {
        this.name = name;
        Debug.Log("Transport constructor");
    }
}

public class Boat : Transport
{
    protected double speed { get; set; }

    public Boat(string name, double speed) : base(name)
    {
        this.speed = speed;
        Debug.Log("Boat constructor");
    }
}

public class JetSki : Boat
{
    protected int numberOfPassengers { get; set; }

    public JetSki(string name, double speed, int numberOfPassengers) : base(name, speed)
    {
        this.numberOfPassengers = numberOfPassengers;
        Debug.Log("JetSki constructor");
    }
}



public class Constructors : MonoBehaviour {

    void OnDisable()
    {
        JetSki jetSki = new JetSki("C# Mobile", 100.0, 2);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
