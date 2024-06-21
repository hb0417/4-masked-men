using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Photo : MonoBehaviour //HSW
{
    public GameObject PhotoUI;
    public PhotoUIMain main;
    public int selectPhotoID;

    public void Open()
    {
        if (main == null)
        {
            main = GameObject.Find("PhotoUIMain").GetComponent<PhotoUIMain>();
        }
        main.selectPhotoID = selectPhotoID;
        PhotoUI.SetActive(true);
    }
    public void Close()
    {
        PhotoUI.SetActive(false);
    }
}
