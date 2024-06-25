using UnityEngine;

[CreateAssetMenuAttribute(fileName = "DefaultPlayerStatsSO", menuName = "player/stats/Default", order = 0)]
public class PlayerStatSO : ScriptableObject
{
    public float tapDamage;
    public float criticalMultiplier;
    public float criticalChance;
}
