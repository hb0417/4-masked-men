using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    TMP_Text textMesh;

    void Awake()
    {
        textMesh = transform.GetChild(0).GetComponent<TMP_Text>();
    }

    void Update()
    {
        textMesh.text = $"Gold: " + Util.Instance.NumConversion(DataManager.Instance.money);
    }
}