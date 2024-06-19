using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Helper : MonoBehaviour
{
    TextMeshProUGUI textMesh;
    int needGold;
    public GameObject prefab;
    Vector3 a;

    void Awake()
    {
        textMesh = GetComponentInChildren<TextMeshProUGUI>();
        needGold = 200;
        a = new Vector3(-2.7f, 1.5f, 0);
    }

    void Update()
    {
        textMesh.text = $"Purchase: {needGold}";
    }
    public void PurchaseHelp()
    {
        if (DataManager.Instance.money >= needGold)
        {
            DataManager.Instance.money -= needGold;
            DataManager.Instance.helperNum++;
            needGold *= 2;
            GameObject myInstance = Instantiate(prefab);
            myInstance.transform.position = a;
            a += new Vector3(0.35f, 0, 0);
        }
    }
}