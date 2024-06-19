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
        needGold = DataManager.Instance.upgrade;
    }

    void Update()
    {
        textMesh.text = $"UPGRADE: {needGold}";
    }

    public void UpgradeUP()
    {
        if (DataManager.Instance.money >= needGold)
        {
            DataManager.Instance.money -= needGold;
            needGold *= 2;
            DataManager.Instance.upgrade++;
        }
    }
}
