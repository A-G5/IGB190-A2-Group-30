using System;
using UnityEngine;

public class PickupKey : MonoBehaviour
{
    public GameObject key;
    bool foundKey = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foundKey = LogicEngine.GetGlobalVariable<bool>("FoundKey");

        if (foundKey == true)
        {
            Destroy(key);
        }
    }
}
