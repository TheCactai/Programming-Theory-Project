using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Title : MonoBehaviour
{
    private static GameObject infoPanel;
    private static TMP_Text titleTypeT;
    private static TMP_Text titleDescriptionT;
    //ENCAPSULATION
    protected string titleType{private get; set;}
    protected string titleDescripion{private get; set;}
    void Start()
    {
        infoPanel = GameObject.Find("InfoPanel");
        titleTypeT = GameObject.Find("TitleType").GetComponent<TMP_Text>();
        titleDescriptionT = GameObject.Find("TitleDescription").GetComponent<TMP_Text>();
    }
    protected virtual void OnMouseDown()
    {
        OpenMenu();
    }
    protected void OpenMenu()
    {
        titleTypeT.SetText(titleType);
        titleDescriptionT.SetText(titleDescripion);
        infoPanel.gameObject.SetActive(true);
        MakeSound();
    }
    //ABSTRACTION
    protected abstract void MakeSound();
}
