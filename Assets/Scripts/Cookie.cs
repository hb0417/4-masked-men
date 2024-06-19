using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    public void Click()
    {
        DataManager.Instance.money += DataManager.Instance.upgrade;
    }
}