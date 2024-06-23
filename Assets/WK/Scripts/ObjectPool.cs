﻿using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public List<Pool> pools = new List<Pool>();
    public Dictionary<string, Queue<GameObject>> PoolDIctionary;


    private void Awake()
    {
        PoolDIctionary = new Dictionary<string, Queue<GameObject>>();

        foreach (var pool in pools)
        {
            Queue<GameObject> queue = new Queue<GameObject>();
            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj;
                if (pool.tag == "HitText")
                {
                    obj = Instantiate(pool.prefab, GameManager.Instance.hitTextSpawnPosition);
                }
                else
                {
                    obj = Instantiate(pool.prefab, transform);
                }

                obj.SetActive(false);
                queue.Enqueue(obj);
            }

            PoolDIctionary.Add(pool.tag, queue);
        }
    }

    public GameObject SpawnFromPool(string tag)
    {
        if (!PoolDIctionary.ContainsKey(tag))
        {
            return null;
        }

        GameObject obj = PoolDIctionary[tag].Dequeue();
        PoolDIctionary[tag].Enqueue(obj);

        obj.SetActive(true);
        return obj;
    }
}
