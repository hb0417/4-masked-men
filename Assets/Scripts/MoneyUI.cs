using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    TMP_Text textMesh;
    public Util util;

    void Awake()
    {
        util = GetComponent<Util>();
        textMesh = transform.GetChild(0).GetComponent<TMP_Text>();
    }

    void Update()
    {
        textMesh.text = $"Gold: " + util.NumConversion(DataManager.Instance.money);
    }
}
