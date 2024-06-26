using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static BossManager;

public class BananaCamera : MonoBehaviour // WK
{
    private int clickCnt;
    [SerializeField] private Text bananaText;

    [SerializeField] private List<Sprite> pictures;

    [SerializeField] private GameObject txt;

    [SerializeField] private GameObject obj;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            obj.SetActive(false);
        }
    }

    public void BanaTxtChange()
    {
        ++clickCnt;
        bananaText.text = clickCnt.ToString();
    }

    public void TryGetPicture()
    {
        int i = Random.Range(0, 5);

        if (i > 3)
        {
            GetPicture();
            GetTextOnOff();
            if (GameManager.Instance.Boss.killBoss != null)
            {
                GameManager.Instance.Boss.killBoss(DataManager.Instance.sprites.Count - 1);
            }
        }
    }

    private void GetPicture()
    {
        if (pictures != null)
        {
            int i = Random.Range(0, pictures.Count);
            DataManager.Instance.sprites.Add(pictures[i]);
        }
    }

    public void GetTextOnOff()
    {
        StartCoroutine(GetTextOn());
        StartCoroutine(GetTextOff());
    }

    private IEnumerator GetTextOn()
    {
        txt.SetActive(true);
        yield return null;
    }

    private IEnumerator GetTextOff()
    {
        yield return new WaitForSeconds(1.5f);
        txt.SetActive(false);
    }
}
