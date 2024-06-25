using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


// 시작화면에서 마우스 클릭후 씬이동
public class LoadSceneOnUIClick : MonoBehaviour
{
    public string sceneName; // 이동할 씬의 이름

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼 클릭 감지
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
