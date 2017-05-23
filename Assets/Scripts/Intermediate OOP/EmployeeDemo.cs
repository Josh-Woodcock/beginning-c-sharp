using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmployeeDemo : MonoBehaviour {


    void OnDisable ()
    {
        Employee employee = new Employee();

        Debug.Log(employee.Speak());

        Mike mike = new Mike();

        Debug.Log(mike.Speak());

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
