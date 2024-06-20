using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    TextMeshProUGUI textMesh;
    int needGold;

    void Awake()
    {
        textMesh = GetComponentInChildren<TextMeshProUGUI>();
        needGold = GameManager.Instance.upgrade;
    }

    void Update()
    {
        textMesh.text = $"UPGRADE: {needGold}";
    }

    public void UpgradeUP()
    {
        if (GameManager.Instance.money >= needGold)
        {
            GameManager.Instance.money -= needGold;
            needGold *= 2;
            GameManager.Instance.upgrade++;
        }
    }
}
