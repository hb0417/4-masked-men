using UnityEngine;

public class BossManager : MonoBehaviour // WK
{
    private int bossSpawnCount = 0;
    private PhotoSelectUIScrollView photoSelectUIScrollView;

    [SerializeField] private BossDataSO[] bossDataSOs;
    [SerializeField] private Boss bossPrefab;
    [HideInInspector] public Boss curBoss;

    private void Awake()
    {
        GameManager.Instance.Boss = this;
        curBoss = Instantiate(bossPrefab, GameManager.Instance.bossSpawnPosition.transform);
        photoSelectUIScrollView = new PhotoSelectUIScrollView();
    }

    private void Start()
    {
        NewSpawnBoss();        
    }

    private void NewSpawnBoss()
    {
        if (bossSpawnCount < bossDataSOs.Length) // 만들어둔 보스 다 잡았냐는 조건
        {
            curBoss.CreateBoss(bossDataSOs[bossSpawnCount]);
            bossSpawnCount++;
        }
        else
        {
            curBoss.ClearCreateBoss(); // 만들어둔 보스 다 잡히면 기본도형 보스 나오게 함.
        }
    }
    
    public void OnDmagable(float PlayerAtkDamage) // 보스 체력 닳게 할 때 이 함수 쓰시면 됩니다.
    {
        float stemina = curBoss.BossDmagable(PlayerAtkDamage);        
        GameManager.Instance.OnHitText(PlayerAtkDamage);        
        curBoss.OnBossSpeech();

        if (stemina < 0)
        {
            CurBosssDie();
        }
    }

    private void CurBosssDie()
    {
        NewSpawnBoss();
        curBoss.GetPicture();
        photoSelectUIScrollView.Init();
    }
}