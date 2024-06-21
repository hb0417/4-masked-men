using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    TMP_Text textMesh;
    public GameObject moneyUI;

    void Awake()
    {
        textMesh = transform.GetChild(0).GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (DataManager.Instance.money < 1000)
        {
            moneyUI.GetComponentInChildren<TMP_Text>().text = $"Gold:" + DataManager.Instance.money.ToString();
        }
        else if (DataManager.Instance.money >= 1000 && DataManager.Instance.money < 1000000)
        {
            moneyUI.GetComponentInChildren<TMP_Text>().text = $"Gold:" + (DataManager.Instance.money / 1000).ToString("F2") + "K";
        }
        else if (DataManager.Instance.money >= 1000000)
        {
            moneyUI.GetComponentInChildren<TMP_Text>().text = $"Gold:" + (DataManager.Instance.money / 1000000).ToString("F2") + "M";
        }
    }
}
