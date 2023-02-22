using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTitle : Title
{
    [SerializeField]private GameObject [] titles;
    protected override void OnMouseDown()
    {
        Instantiate(titles[Random.Range(0,3)], transform.position, transform.rotation);
        Destroy(gameObject);
    }
    protected override void MakeSound()
    {
        Debug.Log("button sound");
    }
}
