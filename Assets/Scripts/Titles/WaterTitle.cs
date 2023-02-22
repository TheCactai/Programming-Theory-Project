using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTitle : Title
{
    void Start()
    {
        titleType = "Water Title";
        titleDescripion = "Good for fishing and water collection";
    }
    //INHERITANCE
    protected override void MakeSound()
    {
        Debug.Log("*waves sounds*");
    }
}
