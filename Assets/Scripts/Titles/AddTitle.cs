using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTitle : Title
{
    [SerializeField]private GameObject [] titles;
    //POLYMORPHISM
    protected override void OnMouseDown()
    {
        Instantiate(titles[Random.Range(0,3)], transform.position, transform.rotation);
        Destroy(gameObject);
    }
    //INHERITANCE
    protected override void MakeSound()
    {
        Debug.Log("button sound");
    }
}
