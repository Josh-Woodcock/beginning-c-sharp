using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IShootable
{
    void Fire();
    void SayHello();
}

class Jet : IShootable
{
    public void Fire()
    {
        Debug.Log("Jet Fires");
    }

    public void SayHello()
    {
        Debug.Log("hi");
    }
}

class InterfaceTank : IShootable
{
    public void Fire()
    {
        Debug.Log("Tank Fires");
    }

    public void SayHello()
    {
        Debug.Log("hi");
    }
}

class Turret : IShootable
{
    public void Fire()
    {
        Debug.Log("Turret Fires");
    }

    public void SayHello()
    {
        Debug.Log("hi");
    }
}

public class InterfaceDemo : MonoBehaviour {

    void OnDisable()
    {
        Jet jet = new Jet();
        InterfaceTank tank = new InterfaceTank();
        Turret turret = new Turret();

        IShootable[] shootables = new IShootable[] { jet, tank, turret };

        foreach ( IShootable shootable in shootables)
        {
            shootable.Fire();
            shootable.SayHello();
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
