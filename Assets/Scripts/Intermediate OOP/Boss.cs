using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {

    protected string name;
    protected string shootText;

    public void Attack()
    {
        Debug.Log(name);
        Debug.Log(shootText);
    }
}

public class IceBoss : Boss
{
    public IceBoss()
    {
        name = "Ice Boss";
        shootText = "Ice Attack";
    }
}


public class FireBoss : Boss
{
    public FireBoss()
    {
        name = "Fire Boss";
        shootText = "Fireball";
    }
}
