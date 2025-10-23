using System;
using UnityEngine;

public class PickupKey : MonoBehaviour
{
    public GameObject key;
    bool FoundKey = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FoundKey = LogicEngine.GetGlobalVariable<bool>("FoundKey");

        if (FoundKey == true)
        {
            Destroy(key);
        }
    }
}
