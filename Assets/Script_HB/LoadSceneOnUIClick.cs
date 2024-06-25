using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


// ����ȭ�鿡�� ���콺 Ŭ���� ���̵�
public class LoadSceneOnUIClick : MonoBehaviour
{
    public string sceneName; // �̵��� ���� �̸�

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ���콺 ���� ��ư Ŭ�� ����
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
