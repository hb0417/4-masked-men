using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
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

    public GameObject parentObject; // 자식 오브젝트의 부모 오브젝트

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        parentObject = GameObject.FindWithTag("Photo");
    }

    private void Start()
    {
        StartCoroutine(CreateChildObjects());
    }
     IEnumerator CreateChildObjects()
    {
        for (int i = 0; i < DataManager.Instance.sprites.Count; i++)
        {
            GameObject childObject = new GameObject("Child Object " + i);
            childObject.transform.SetParent(parentObject.transform);

            SpriteRenderer spriteRenderer = childObject.AddComponent<SpriteRenderer>();
            spriteRenderer.sprite = DataManager.Instance.sprites[i];
        }
        yield return null;
        StartCoroutine(CreateChildObjects());
    }
}