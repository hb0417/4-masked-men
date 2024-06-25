using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerStatHandler : MonoBehaviour
{
    [SerializeField] private PlayerStat baseStat;
    public PlayerStat CurrentStat { get; private set; } = new PlayerStat();
    public List<PlayerStat> statsModifiers = new List<PlayerStat>();

    private readonly float MinTapDamage = 1.0f;
    private readonly float MincriticalMultiplier = 1.0f;
    private readonly float MincriticalChance = 1.0f;

    private void Awake()
    {
        if (baseStat.playerStatSO != null)
        {
            baseStat.playerStatSO = Instantiate(baseStat.playerStatSO);
            CurrentStat.playerStatSO = Instantiate(baseStat.playerStatSO);
        }

        UpdateCharacterStat();
        Debug.Log(CurrentStat.playerStatSO.tapDamage);
    }

    public void AddStatModifier(PlayerStat modifierStat)
    {
        statsModifiers.Add(modifierStat);
        UpdateCharacterStat();
    }

    public void RemoveStatModifier(PlayerStat modifierStat)
    {
        statsModifiers.Remove(modifierStat);
        UpdateCharacterStat();
    }

    private void UpdateCharacterStat()
    {
        ApplyStatModifiers(baseStat);

        foreach (var modifier in statsModifiers.OrderBy(o => o.statChangeType))
        {
            ApplyStatModifiers(modifier);
        }
    }

    private void ApplyStatModifiers(PlayerStat playerStat)
    {

        Func<float, float, float> operation = playerStat.statChangeType switch
        {
            StatChangeType.Add => (current, change) => current + change,
            StatChangeType.Multiple => (current, change) => current * change,
            _ => (current, change) => change,
        };

        UpdateAttackStats(operation, playerStat);

    }

    private void UpdateAttackStats(Func<float, float, float> operation, PlayerStat playerStat)
    {
        if (CurrentStat.playerStatSO == null || playerStat.playerStatSO == null) return;

        var currentStatSO = CurrentStat.playerStatSO;
        var newStatSO = playerStat.playerStatSO;

        currentStatSO.tapDamage = Mathf.Max(operation(currentStatSO.tapDamage, newStatSO.tapDamage), MinTapDamage);
        currentStatSO.criticalMultiplier = Mathf.Max(operation(currentStatSO.criticalMultiplier, newStatSO.criticalMultiplier), MincriticalMultiplier);
        currentStatSO.criticalChance = Mathf.Max(operation(currentStatSO.criticalChance, newStatSO.criticalChance), MincriticalChance);
    }

}
