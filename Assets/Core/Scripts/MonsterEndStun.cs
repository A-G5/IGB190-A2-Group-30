using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterEndStun : MonoBehaviour
{
    public GameObject monster;
    public bool stunImmune;

    private void Update()
    {
        if (stunImmune == true)
        {
            monster.GetComponent<Monster>().isStunned = false;
        }
    }

    private void EndStun()
    {
        if (monster != null)
        {
            monster.GetComponent<Monster>().isStunned = false;
        }
    }
}
