using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleTitle : Title
{
    void Start()
    {
        titleType = "Castle";
        titleDescripion = "This is the center of the city";
    }
    protected override void MakeSound()
    {
        Debug.Log("*people talking*");
    }
}
