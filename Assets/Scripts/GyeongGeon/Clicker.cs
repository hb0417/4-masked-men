using Unity.VisualScripting;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public PlayerStatHandler playerStatHandler;

    public float autoClickInterval = 1.0f; // 1초마다 자동 클릭
    private float timer;

    private void Awake()
    {
        playerStatHandler = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatHandler>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= autoClickInterval)
        {
            timer = 0f;
            OnClick();
        }
    }

    public void OnClick()
    {
        DataManager.Instance.money += playerStatHandler.CurrentStat.playerStatSO.tapDamage;
        GameManager.Instance.Boss.OnDmagable(playerStatHandler.CurrentStat.playerStatSO.tapDamage);
    }
}