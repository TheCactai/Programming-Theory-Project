using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestTitle : Title
{
    void Start()
    {
        titleType = "Forest Title";
        titleDescripion = "Best place for a lumber mill or a hunting ground";
    }
    //INHERITANCE
    protected override void MakeSound()
    {
        Debug.Log("*leaves in the wind*");
    }
}
