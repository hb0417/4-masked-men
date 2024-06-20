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
        Debug.Log(DataManager.Instance.sprites.Count);
        photoNum = int.Parse(DataManager.Instance.sprites[photoNum].name);
        photoSprite = DataManager.Instance.sprites[photoNum - 1];
        btnPhoto.GetComponentInChildren<TMP_Text>().text = $"   Num.{photoNum}";
    }
}
