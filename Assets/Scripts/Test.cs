using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Sprite sprite;

    void Start()
    {
        DataManager.Instance.sprites.Add(sprite);
    }
}
