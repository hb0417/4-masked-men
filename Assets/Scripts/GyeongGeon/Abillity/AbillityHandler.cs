using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AbillityHandler : MonoBehaviour
{
    public Abillity abillity;
    private PlayerStatHandler playerStatHandler;
    private IAbillityEffect abillityEffect;

    private void Awake()
    {
        playerStatHandler = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatHandler>();
    }

    private void Start() 
    {
        switch (abillity.abillitySO.abillityName)
        {
            case "AttackUpgrade":
                abillityEffect = new AttackUpgrade();
                break;
            case "DoubleAttackUpgrade":
                abillityEffect = new DoubleAttackUpgrade();
                break;
            case "CriticalChanceUpgrade":
                abillityEffect = new CriticalChanceUpgrade();
                break;
            case "CriticalMultipleUpgrade":
                abillityEffect = new CriticalMultipleUpgrade();
                break;
        }

        ChangeViewAbillity();
    }

    private void Update() 
    {
        ChangeViewAbillity();
    }

    public void OnClickUpgrade()
    {
        abillityEffect.EffectApply(abillity, playerStatHandler);
    }

    void ChangeViewAbillity()
    {
        ChangeImage();
        ChangePrice();
        ChangeInfo();
    }

    void ChangeImage()
    {
        this.gameObject.transform.GetChild(0).transform.GetComponent<Image>().sprite = abillity.abillitySO.sprite;
    }

    void ChangePrice()
    {
        this.gameObject.transform.GetChild(1).transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = abillity.abillitySO.price.ToString();
    }

    void ChangeInfo()
    {
        this.gameObject.transform.GetChild(2).transform.GetComponent<TextMeshProUGUI>().text = abillity.abillitySO.abillityName + $"\nLV : " + abillity.abillitySO.level.ToString() + $"\nCurVal : " + abillity.abillitySO.currentValue.ToString();
    }

    void ChangeLevel()
    {
        //this.gameObject.transform.GetChild(3).transform.GetComponent<TextMeshProUGUI>().text = $"LV : " + abillity.abillitySO.level.ToString()+"\n"+$"DMG : " + abillity.abillitySO.currentValue.ToString();
    }

    void ChangeEffect()
    {
        //this.gameObject.transform.GetChild(4).transform.GetComponent<TextMeshProUGUI>().text = $"DMG : " + abillity.abillitySO.currentValue.ToString();
    }


}
