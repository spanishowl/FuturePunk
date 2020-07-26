using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    int fuelCapacity;
    int speedCapacity;
    List<Weapon> weapons;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool IsDisabled()
    {
        return fuelCapacity == 0 || speedCapacity == 0;
    }

}
