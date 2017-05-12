using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }
}

public class PropetyPerson : MonoBehaviour {

    public string firstName;
    public string lastName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnDisable ()
    {
        Person person = new Person();
        person.FirstName = firstName;
        person.LastName = lastName;
        Debug.Log(person.FullName);
       
    }
}
