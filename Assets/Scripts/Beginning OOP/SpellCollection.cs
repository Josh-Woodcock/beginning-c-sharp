using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCollection : MonoBehaviour {

    void OnDisable()
    {
        Spell IceBall = new Spell("Iceball", 10, 1);
        Spell Fireball = new Spell("Fireball", 100, 1);
        Spell EarthShake = new Spell("EarthShake", 10, 100.0f);

        Debug.Log(IceBall.GetSpellStats());
        Debug.Log(Fireball.GetSpellStats());
        Debug.Log(EarthShake.GetSpellStats());

    }
}
