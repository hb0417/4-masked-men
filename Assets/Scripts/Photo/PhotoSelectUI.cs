using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoSelectUI : MonoBehaviour
{
    public PhotoSelectUIScrollView photoSelectUIScrollView;
    public int ID;

    public void Init()
    {
        //��ũ�� �� �ʱ�ȭ
        this.photoSelectUIScrollView.Init();
    }
}
