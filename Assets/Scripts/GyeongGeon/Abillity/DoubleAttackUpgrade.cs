using UnityEngine;

public class DoubleAttackUpgrade : IAbillityEffect
{
    public void EffectApply(Abillity abillity, PlayerStatHandler playerStatHandler)
    {
        PlayerStat modifierStat = new PlayerStat();
        modifierStat.playerStatSO = ScriptableObject.CreateInstance<PlayerStatSO>();
        modifierStat.statChangeType = StatChangeType.Add;
        modifierStat.playerStatSO.tapDamage = abillity.abillitySO.increaseValue;

        playerStatHandler.AddStatModifier(modifierStat);

        ChangeIncreaseAbillity(abillity);
    }

    void ChangeIncreaseAbillity(Abillity _abillity)
    {
        _abillity.abillitySO.currentValue += _abillity.abillitySO.increaseValue;
        _abillity.abillitySO.price += 100;
        _abillity.abillitySO.level += 1;
        _abillity.abillitySO.increaseValue += 10;
    }
}
