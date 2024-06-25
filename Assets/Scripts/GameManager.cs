using System.Collections;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public ObjectPool ObjectPool { get; private set; }
    public Transform hitTextSpawnPosition;

    public GameObject bossSpawnPosition;
    public int photoPrefabID;
    

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject go = new GameObject("GameManager");
                    instance = go.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }

    private BossManager boss;

    public BossManager Boss
    {
        get { return boss; }
        set { boss = value; }
    }

    private Upgrade upgrade;

    public Upgrade Upgrade
    {
        get { return upgrade; }
        set { upgrade = value; }
    }

    private void Awake()
    {
        ObjectPool = GetComponent<ObjectPool>();

        if (instance == null)
        {
            instance = this;

        }
    }

    public void OnHitText(float Atk)
    {
        HitTextSpawn(Atk);
    }

    private void HitTextSpawn(float value)
    {
        GameObject text = ObjectPool.SpawnFromPool("HitText");
        HitText hitText = text.GetComponent<HitText>();
        hitText.HitTextEnter(value);
    }

}