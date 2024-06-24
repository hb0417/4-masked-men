using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;

public class Util : MonoBehaviour 
{
    private static Util _instance;
    public static Util Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<Util>();
                if (_instance == null)
                {
                    GameObject go = new GameObject("Util");
                    _instance = go.AddComponent<Util>();
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }

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
            if (RandomPercent(itemDropPercent))
            {
                Instantiate(dropOnDeath[i].dropPrefab, transform.position + Vector3.up * 2, Quaternion.identity);
            }
        }
    }

    public string NumConversion(float num)
    {
        string answer = string.Empty;

        if (num < 1000)
        {
            answer =  num.ToString();
        }
        else if (num >= 1000 && num < 1000000)
        {
            answer = (num / 1000).ToString("F2") + "K";
        }
        else if (num >= 1000000)
        {
            answer = (num / 1000000).ToString("F2") + "M";
        }
        return answer;
    }
}
