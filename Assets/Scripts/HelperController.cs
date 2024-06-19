using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperController : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(MakeMoney());
    }

    IEnumerator MakeMoney()
    {
        DataManager.Instance.money++;
        yield return new WaitForSecondsRealtime(1f);
        StartCoroutine(MakeMoney());
    }
}
