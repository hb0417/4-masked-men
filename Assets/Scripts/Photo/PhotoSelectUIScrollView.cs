using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoSelectUIScrollView : MonoBehaviour
{
    public PhotoUIMain main;
    public Transform contentsTrans;
    public GameObject photoPrefab;
    public GameObject photoFrame;
    public int selectPhotoID;

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
        photoFrame = GameObject.Find($"Frame{selectPhotoID}").transform.Find("Photo").gameObject;
        photoFrame.SetActive(true);
        photoFrame.GetComponent<SpriteRenderer>().sprite = photoPrefab.photoSprite;
    }
}
