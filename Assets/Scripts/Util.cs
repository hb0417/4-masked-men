using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour
{
    public bool RandomPercent(float percent)
    {
        bool result;
        percent /= 100f;

        if (percent >= Random.Range(0f, 1f)) result = true;
        else result = false;
        return result;
    }

    public void RandomItemDrop(ItemData[] dropOnDeath, int maxDropItemNum, float itemDropPercent)
    {
        for (int i = 0; i < maxDropItemNum + 1; i++)
        {
            RandomPercent(itemDropPercent);
            if (RandomPercent(itemDropPercent))
            {
                Instantiate(dropOnDeath[i].dropPrefab, transform.position + Vector3.up * 2, Quaternion.identity);
            }
        }
    }
}
