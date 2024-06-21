using UnityEngine;

[CreateAssetMenuAttribute(fileName = "DefaultAbillitySO", menuName = "tab/abillity/Default", order = 0)]
public class AbillitySO : ScriptableObject
{
    public Sprite sprite;
    public string abillityName;
    public string explanation;
    public float price;
    public int level;
    public float currentValue;
    public float increaseValue;
}
