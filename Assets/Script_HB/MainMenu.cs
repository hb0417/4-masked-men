using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//여현빈
// UI관련
public class MainMenu : MonoBehaviour
{
    public string collectionSceneName; // 유니티 에디터에서 설정할 씬 이름 입력

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
        Debug.Log("능력치");
    }

    public void OnClickItem()
    {
        Debug.Log("아이템");
    }

    public void OnClickStore()
    {
        Debug.Log("상점");
    }

    public void OnClickCollection()
    {
        Debug.Log("겔러리");
        SceneManager.LoadScene(collectionSceneName); // 설정한 씬 이름으로 이동
    }

    public void OnClickSetting()
    {
        Debug.Log("설정");
    }
}
