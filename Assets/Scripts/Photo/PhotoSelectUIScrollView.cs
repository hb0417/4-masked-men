using Assets.Scripts.Common;
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
        //목록에 있는 거 생성
        for (int i = 0; i < DataManager.Instance.sprites.Count; i++)
        {
            this.AddPhoto();
        }
    }
    public void AddPhoto()
    {
        var go = Instantiate(this.photoPrefab, this.contentsTrans);
        PhotoPrefab photo = go.GetComponent<PhotoPrefab>();
        photo.btnPhoto.onClick.AddListener(() => {
            SpriteChange(photo);
        });
    }

    public void SpriteChange(PhotoPrefab photoPrefab)
    {
        selectPhotoID = main.selectPhotoID;
        photoFrame = totalFrame.transform.GetChild(selectPhotoID-1).transform.GetChild(0).gameObject;
        photoFrame.SetActive(true);
        photoFrame.GetComponent<Image>().sprite = photoPrefab.photoSprite;
        ui.SetActive(false);
    }
}
