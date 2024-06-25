using UnityEngine;

public class CriticalChanceUpgrade : IAbillityEffect
{
    public void EffectApply(Abillity abillity, PlayerStatHandler playerStatHandler)
    {
        PlayerStat modifierStat = new PlayerStat();
        modifierStat.playerStatSO = ScriptableObject.CreateInstance<PlayerStatSO>();
        modifierStat.statChangeType = StatChangeType.Add;
        modifierStat.playerStatSO.criticalChance = abillity.abillitySO.increaseValue;

        playerStatHandler.AddStatModifier(modifierStat);

        ChangeIncreaseAbillity(abillity);
    }

    void ChangeIncreaseAbillity(Abillity _abillity)
    {
        DataManager.Instance.money -= _abillity.abillitySO.price;
        _abillity.abillitySO.currentValue += _abillity.abillitySO.increaseValue;
        _abillity.abillitySO.price += 10000;
        _abillity.abillitySO.level += 1;
        _abillity.abillitySO.increaseValue += 1;
    }
}
