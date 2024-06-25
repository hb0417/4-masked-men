using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour // WK
{
    private int randomNum;

    private float baseBossStemina;
    private float curBossStemina;

    public Image bossImage; // ���� �̹���
    [SerializeField] private TextMeshProUGUI bossNameTxt; // ���� �̸�

    [SerializeField] private Transform bossSpeechBubble; //���� ��ǳ��
    [SerializeField] private TextMeshProUGUI bossSpeechTxt; // ���� ���

    [SerializeField] private Image bossHealthBar;

    private BossDataSO curSO;

    [SerializeField] private Sprite circleSprite; // ���� Ŭ���� �Ŀ� ���� �����̹���

    public void CreateBoss(BossDataSO SO)
    {
        curSO = SO;
        BossDataEnter();
    }

    public void ClearCreateBoss() // ���� �� ������ �ڿ� ��� ���� �Ǵ� ����,
    {
        baseBossStemina *= 2; // ���� ���� ������ ü�� �׳� 2��ó��
        curBossStemina = baseBossStemina;

        bossImage.sprite = circleSprite;

        bossImage.color = GetRandomColor(); // �����÷��Լ�

        bossNameTxt.text = "���� Ŭ����"; // �����̸�
    }

    public void OnBossSpeech() // ���� ��ǳ�� ����
    {
        int a = Random.Range(0, 10);
        if (a > 4) return;
        StartCoroutine(OnBossSpeechBubble());
    }

    public void TryGetPicture()
    {
        if (Util.Instance.RandomPercent(0.1f))
        {
            DataManager.Instance.sprites.Add(ReturnPicture());
        }
    }

    private void BossDataEnter() // ���� ������ �ʱ�ȭ
    {
        bossImage.sprite = curSO.bossImage;
        bossNameTxt.text = curSO.bossName;

        baseBossStemina = curSO.bossStemina;
        curBossStemina = baseBossStemina;
    }

    private IEnumerator OnBossSpeechBubble()
    {
        bossSpeechBubble.gameObject.SetActive(false);
        ChangeBossSpeech();
        bossSpeechBubble.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.8f); ;
        bossSpeechBubble.gameObject.SetActive(false);
    }

    private void ChangeBossSpeech()
    {
        if (curSO != null)
        {
            randomNum = Random.Range(0, curSO.bossSpeech.Length);
            bossSpeechTxt.text = curSO.bossSpeech[randomNum];
        }
    }

    public float BossDmagable(float PlayerAtkDmage)
    {
        curBossStemina -= PlayerAtkDmage;
        UpdateHealthBar();
        return curBossStemina;
    }

    private void UpdateHealthBar()
    {
        bossHealthBar.fillAmount = curBossStemina / baseBossStemina;
    }

    public Color GetRandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        return new Color(r, g, b);
    }

    private int ReturnGold()
    {
        return curSO.reward.dropGold;
    }

    private Sprite ReturnPicture()
    {
        int i = Random.Range(0, curSO.reward.BossPicture.Length); // ���� �� ���� ������. // ���߿� óġ�������� ��� ������ ���� �� �ϰ� �ϴ� �ڵ� �߰�.
        if(curSO != null) return curSO.reward.BossPicture[i];
        else return null;
    }
}
