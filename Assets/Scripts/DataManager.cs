using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    [Header("Field")]
    public float money = 0;
    public int upgrade = 1;
    public int helperNum = 0;

    [Header("Photo")]
    public List<Sprite> sprites;
    public Test test;

    [Header("Boss")]

    [Header("Player")]
    public string playerName = "";

    private static DataManager _instance;
    public static DataManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<DataManager>();
                if (_instance == null)
                {
                    GameObject go = new GameObject("DataManager");
                    _instance = go.AddComponent<DataManager>();
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

        //test = GameObject.Find("Test").GetComponent<Test>();
        sprites = new List<Sprite>();
        //test.Give();
    }

    public void NameSet(string name)
    {
        playerName = name;
    }
}
public class ItemData
{
    public GameObject dropPrefab;
}