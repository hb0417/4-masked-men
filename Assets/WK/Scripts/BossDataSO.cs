using UnityEngine;

[System.Serializable]
public class BossReward // WK
{
    public int dropGold;
    public Sprite[] BossPicture; //���� ������
}

[CreateAssetMenu(fileName = "BossSO", menuName = "SO/NewBossDataSO")]
public class BossDataSO : ScriptableObject // Wk
{
    public BossReward reward; // ���� ��� ������
    
    [Header("BossInfo")]
    public string bossName;  // ���� �̸�
    public float bossStemina; // ���� ü��
    public Sprite bossImage; // ���� �̹���

    public string[] bossSpeech; // ���� ���� ����
}
