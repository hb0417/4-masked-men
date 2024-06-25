using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageUI : MonoBehaviour
{
    TMP_Text textMesh;
    PlayerStatHandler playerStatHandler;

    void Awake()
    {
        playerStatHandler = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatHandler>();
        textMesh = transform.GetChild(0).GetComponent<TMP_Text>();
    }

    void Update()
    {
        textMesh.text = $"DMG : " + Util.Instance.NumConversion(playerStatHandler.CurrentStat.playerStatSO.tapDamage);
    }
}