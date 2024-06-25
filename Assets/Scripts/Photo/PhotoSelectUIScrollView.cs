using Assets.Scripts.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoSelectUIScrollView : MonoBehaviour
{
    public PhotoUIMain main;
    public PhotoSelectUI ui;
    public Transform contentsTrans;
    public GameObject photoPrefab;
    public GameObject totalFrame;
    private GameObject photoFrame;
    private int selectPhotoID;

    public void Init()
    {
        GameManager.Instance.Boss.killBoss += AddPhoto;
        if (DataManager.Instance.sprites.Count != 0)
        {
            for(int i = 0;i < DataManager.Instance.sprites.Count; i++)
            {
                //목록에 사진 생성
                this.AddPhoto(i);
            }
        }
    }

    public void AddPhoto(int index)
    {
        Debug.Log(DataManager.Instance.sprites.Count);
        var go = Instantiate(this.photoPrefab, this.contentsTrans);
        PhotoPrefab photo = go.GetComponent<PhotoPrefab>();
        photo.btnPhoto.onClick.AddListener(() =>
        {
            SpriteChange(photo);
        });
        photo.Init(index);
    }

    //밖에 보이는 사진 수정
    public void SpriteChange(PhotoPrefab photoPrefab)
    {
        selectPhotoID = main.selectPhotoID;
        photoFrame = totalFrame.transform.GetChild(selectPhotoID - 1).transform.GetChild(0).gameObject;
        photoFrame.SetActive(true);
        photoFrame.GetComponent<Image>().sprite = photoPrefab.photoSprite;
        ui.SetActive(false);
    }

    public void BossDie()
    {
        GameManager.Instance.Boss.killBoss -= AddPhoto;
    }
}
