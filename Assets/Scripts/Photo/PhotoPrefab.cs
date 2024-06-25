using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PhotoPrefab : MonoBehaviour
{
    public Sprite photoSprite;
    public Button btnPhoto;
    public int photoNum;


    public void Start()
    {
        photoNum = DataManager.Instance.sprites.Count - 1;
        photoSprite = DataManager.Instance.sprites[photoNum];
        btnPhoto.GetComponentInChildren<TMP_Text>().text = $"  Num.{photoNum + 1}";
    }
}
