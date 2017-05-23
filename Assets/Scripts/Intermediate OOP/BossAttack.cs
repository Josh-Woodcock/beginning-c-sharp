using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour {

	void OnDisable()
    {
        IceBoss  lapras = new IceBoss();
        FireBoss charmander = new FireBoss();

        lapras.Attack();
        charmander.Attack();

    }
}
