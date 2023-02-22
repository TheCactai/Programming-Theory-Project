using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandTitle : Title
{
    void Start()
    {
        titleType = "Sand Title";
        titleDescripion = "Not very suitable for building or farming";
    }
    //INHERITANCE
    protected override void MakeSound()
    {
        Debug.Log("*wind blows sand*");
    }
}
