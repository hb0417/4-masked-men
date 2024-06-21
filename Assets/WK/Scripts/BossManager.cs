using UnityEngine;

public class BossManager : MonoBehaviour // WK
{
    private int bossSpawnCount = 0;

    [SerializeField] private BossDataSO[] bossDataSOs;
    [SerializeField] private Boss bossPrefab;
    public Boss curBoss;

    private void Awake()
    {
        GameManager.Instance.Boss = this;
        curBoss = Instantiate(bossPrefab);
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
        //curBoss.TryGetPicture(); // 공격 할 때 랜덤으로 사진 얻기.

        if (stemina < 0)
        {
            CurBosssDie();
            // 맞을 때 랜덤 대사 출력 
        }
    }

    private void CurBosssDie()
    {
            NewSpawnBoss();

            // 아이템추가나 등등등 
    }
}