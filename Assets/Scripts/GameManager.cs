using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public ObjectPool ObjectPool { get; private set; }
    public Transform hitTextSpawnPosition;

    public GameObject bossSpawnPosition;
    public int photoPrefabID;

    [SerializeField] private GameObject getText;

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

    public void GetTextOnOff()
    {
        StartCoroutine(GetTextOn());
        StartCoroutine(GetTextOff());
    }

    private IEnumerator GetTextOn()
    {
        getText.SetActive(true);
        yield return null;
    }

    private IEnumerator GetTextOff()
    {
        yield return new WaitForSeconds(1.5f);
        getText.SetActive(false);
    }
}