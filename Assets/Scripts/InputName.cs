using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    private string playerName = null;

    private void Awake()
    {
        playerName = playerNameInput.GetComponent<TMP_InputField>().text;
    }

    private void Update()
    {
        playerName = playerNameInput.text;
        //키보드
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (playerName.Length > 0)
            {
                InputPlayerName();
            }
        }
    }

    //마우스
    public void InputPlayerName()
    {
        playerName = playerNameInput.text;
        DataManager.Instance.NameSet(playerName);
        SceneManager.LoadScene("MainScene");
    }
}
