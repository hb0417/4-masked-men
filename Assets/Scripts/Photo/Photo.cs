using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Photo : MonoBehaviour //HSW
{
    public GameObject ACTUI;
    public PhotoUIMain main;
    public int selectPhotoID;

    public void Open()
    {
        if (main == null)
        {
            main = GameObject.Find("PhotoUIMain").GetComponent<PhotoUIMain>();
        }
        main.selectPhotoID = selectPhotoID;
        ACTUI.SetActive(true);
    }
    public void Close()
    {
        ACTUI.SetActive(false);
    }
}
