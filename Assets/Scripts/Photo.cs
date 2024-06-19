using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Photo : MonoBehaviour //HSW
{
    public GameObject PhotoUI;

    public void Open()
    {
        PhotoUI.SetActive(true);
    }
    public void Close()
    {
        PhotoUI.SetActive(false);
    }
}
