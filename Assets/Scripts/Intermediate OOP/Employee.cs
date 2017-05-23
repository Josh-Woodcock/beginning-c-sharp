using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee {

    public string speak;

    public virtual string Speak()
    {
        return "I am an Employee";
    }
}

public class Mike : Employee
{
    public override string Speak()
    {
        return base.Speak() + " I am Mike";
    } 
}
