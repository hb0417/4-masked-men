using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Profile : MonoBehaviour
{
    public GameObject profile;
    private TMP_Text tmptext;

    private void Awake()
    {
        tmptext = profile.transform.Find("Player_Name").GetComponent<TMP_Text>();
    }
    private void Start()
    {
        tmptext.text = DataManager.Instance.playerName;
    }
}
