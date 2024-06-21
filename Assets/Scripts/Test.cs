using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Sprite sprite;

    public void Give()
    {
        DataManager.Instance.sprites.Add(sprite);
    }
}
