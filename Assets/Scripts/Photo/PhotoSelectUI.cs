using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoSelectUI : MonoBehaviour
{
    public PhotoSelectUIScrollView photoSelectUIScrollView;
    public int ID;

    public void Init()
    {
        //스크롤 뷰 초기화
        this.photoSelectUIScrollView.Init();
    }
}
