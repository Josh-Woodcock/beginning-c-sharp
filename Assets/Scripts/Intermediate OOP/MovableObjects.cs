using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IMovable
{
    void Drive();
}

class Bike : IMovable
{
    public void Drive()
    {
        Debug.Log("crank crank");
    }
}

class InterfaceCar : IMovable
{
    public void Drive()
    {
        Debug.Log("vroom vroom");
    }
}

class GolfCart : IMovable
{
   public void Drive()
    {
        Debug.Log("silent");
    }
}




public class MovableObjects : MonoBehaviour {

    void OnDisable()
    {
        IMovable[] movables = new IMovable[] { new Bike() , new InterfaceCar(), new GolfCart()};

        foreach (IMovable movable in movables )
        {
            movable.Drive();
        }
    }





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
