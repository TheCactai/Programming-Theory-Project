using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassTitle : Title
{
    // Start is called before the first frame update
    void Start()
    {
        titleType = "Grass Title";
        titleDescripion = "Good for farms and animals";
    }
    protected override void MakeSound()
    {
        Debug.Log("*grass ruffles*");
    }
}
