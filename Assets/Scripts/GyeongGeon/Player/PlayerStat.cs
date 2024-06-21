using System;

public enum StatChangeType
{
    Add,
    Multiple,
    Override
}

[Serializable]
public class PlayerStat
{
    public StatChangeType statChangeType;
    public PlayerStatSO playerStatSO;
}
