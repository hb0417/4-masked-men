using UnityEngine;
using UnityEngine.UI;

public class BananaCamera : MonoBehaviour // WK
{
    private int clickCnt;
    [SerializeField] private Text bananaText;

    public void BanaTxtChange()
    {
        ++clickCnt;
        bananaText.text = clickCnt.ToString();
    }
}
