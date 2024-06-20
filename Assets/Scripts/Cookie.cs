using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    public void Click()
    {
        GameManager.Instance.money += GameManager.Instance.upgrade;
    }
}