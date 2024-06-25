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

    public Image bossImage; // 보스 이미지
    [SerializeField] private TextMeshProUGUI bossNameTxt; // 보스 이름

    [SerializeField] private Transform bossSpeechBubble; //보스 말풍선
    [SerializeField] private TextMeshProUGUI bossSpeechTxt; // 보스 대사

    [SerializeField] private Image bossHealthBar;

    private BossDataSO curSO;

    [SerializeField] private Sprite circleSprite; // 게임 클리어 후에 나올 보스이미지

    [SerializeField] private Animator hitanimator;
    [SerializeField] private AudioClip HitClip;

    public void CreateBoss(BossDataSO SO)
    {
        curSO = SO;
        BossDataEnter();
    }

    public void ClearCreateBoss() // 보스 다 잡히고 뒤에 계속 스폰 되는 보스,
    {
        baseBossStemina *= 2; // 보스 잡힐 때마다 체력 그냥 2배처리
        curBossStemina = baseBossStemina;

        bossImage.sprite = circleSprite;

        bossImage.color = GetRandomColor(); // 랜덤컬러함수

        bossNameTxt.text = "게임 클리어"; // 보스이름
    }

    public void OnBossHitAnim()
    {
        IsBossHit();
    }

    public void OnBossSpeech() // 보스 말풍선 시작
    {
        int a = Random.Range(0, 10);
        if (a > 2) return;
        StartCoroutine(OnBossSpeechBubble());
    }

    public void GetPicture()
    {
        DataManager.Instance.sprites.Add(ReturnPicture());
    }

    private void BossDataEnter() // 보스 데이터 초기화
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
            int i = Random.Range(0, curSO.reward.BossPicture.Count); // 랜덤 한 사진 보내줌. // 나중에 처치보상으로 얻는 사진은 얻지 못 하게 하는 코드 추가.
            return curSO.reward.BossPicture[i];
        }
        else return null;
    }

    private void IsBossHit()
    {
        hitanimator.SetTrigger(BossHit);
    }
}
