using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterEndStun : MonoBehaviour
{
    public GameObject monster;
    private void EndStun()
    {
        if (monster != null)
        {
            monster.GetComponent<Monster>().isStunned = false;
        }
        
    }
}
