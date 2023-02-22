using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Title : MonoBehaviour
{
    [SerializeField] private GameObject infoPanel;
    [SerializeField] private TMP_Text titleTypeT;
    [SerializeField] private TMP_Text titleDescriptionT;
    protected string titleType = "unknown";
    protected string titleDescripion = "unknown";
    void Start()
    {

    }
    void OnMouseDown()
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
    protected abstract void MakeSound();
}
