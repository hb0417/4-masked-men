using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    TextMeshProUGUI textMesh;
    TextMeshProUGUI textMesh2;

    void Awake()
    {
        textMesh = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        textMesh2 = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        textMesh.text = $"Gold: {GameManager.Instance.money}";
        textMesh2.text = $"Helper: {GameManager.Instance.helperNum}";
    }
}
