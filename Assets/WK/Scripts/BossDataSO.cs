using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BossReward // WK
{
    public int dropGold;
    public List<Sprite> BossPicture; //보스 사진들
}

[CreateAssetMenu(fileName = "BossSO", menuName = "SO/NewBossDataSO")]
public class BossDataSO : ScriptableObject // Wk
{
    public BossReward reward; // 보스 드랍 아이템
    
    [Header("BossInfo")]
    public string bossName;  // 보스 이름
    public float bossStemina; // 보스 체력
    public Sprite bossImage; // 보스 이미지

    public string[] bossSpeech; // 보스 대사들 모음
}
