using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour // WK
{
    private static readonly int BossHit = Animator.StringToHash("BossHit");

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

    [SerializeField] private Animator hitanimator;
    [SerializeField] private AudioClip HitClip;

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

    public void OnBossHitAnim()
    {
        IsBossHit();
    }

    public void OnBossSpeech() // ���� ��ǳ�� ����
    {
        int a = Random.Range(0, 10);
        if (a > 2) return;
        StartCoroutine(OnBossSpeechBubble());
    }

    public void GetPicture()
    {
        DataManager.Instance.sprites.Add(ReturnPicture());
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

        yield return new WaitForSeconds(0.4f); ;
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
        if (HitClip) MainSoundManager.PlayClip(HitClip);

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
        if (curSO != null)
        {
            int i = Random.Range(0, curSO.reward.BossPicture.Count); // ���� �� ���� ������. // ���߿� óġ�������� ��� ������ ���� �� �ϰ� �ϴ� �ڵ� �߰�.
            return curSO.reward.BossPicture[i];
        }
        else return null;
    }

    private void IsBossHit()
    {
        hitanimator.SetTrigger(BossHit);
    }
}
