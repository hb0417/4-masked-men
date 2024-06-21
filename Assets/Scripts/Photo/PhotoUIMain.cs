using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoUIMain : MonoBehaviour
{
    public PhotoSelectUI photoSelectUI;
    public int selectPhotoID;
    void Start()
    {
        this.photoSelectUI.Init();
    }
}
