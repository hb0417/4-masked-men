using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public ObjectPool ObjectPool { get; private set; }
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

    private void Awake()
    {
        ObjectPool = GetComponent<ObjectPool>();

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private BossManager boss;
    public BossManager Boss
    {
        get { return boss; }
        set { boss = value; }
    }
}