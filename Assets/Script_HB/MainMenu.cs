using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//������
// UI����
public class MainMenu : MonoBehaviour
{
    public string collectionSceneName; // ����Ƽ �����Ϳ��� ������ �� �̸� �Է�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickAbllity()
    {
        Debug.Log("�ɷ�ġ");
    }

    public void OnClickItem()
    {
        Debug.Log("������");
    }

    public void OnClickStore()
    {
        Debug.Log("����");
    }

    public void OnClickCollection()
    {
        Debug.Log("�ַ���");
        SceneManager.LoadScene(collectionSceneName); // ������ �� �̸����� �̵�
    }

    public void OnClickSetting()
    {
        Debug.Log("����");
    }
}
