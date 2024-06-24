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
        }

        ChangeAbillity();
    }

    private void Update() 
    {
        ChangeAbillity();
    }

    public void OnClickUpgrade()
    {
        abillityEffect.EffectApply(abillity, playerStatHandler);
    }

    void ChangeAbillity()
    {
        ChangeImage();
        ChangePrice();
        ChangeName();
        ChangeLevel();
        ChangeEffect();
    }

    void ChangeImage()
    {
        this.gameObject.transform.GetChild(0).transform.GetComponent<Image>().sprite = abillity.abillitySO.sprite;
    }

    void ChangePrice()
    {
        this.gameObject.transform.GetChild(1).transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = abillity.abillitySO.price.ToString();
    }

    void ChangeName()
    {
        this.gameObject.transform.GetChild(2).transform.GetComponent<TextMeshProUGUI>().text = abillity.abillitySO.abillityName;
    }

    void ChangeLevel()
    {
        this.gameObject.transform.GetChild(3).transform.GetComponent<TextMeshProUGUI>().text = abillity.abillitySO.level.ToString();
    }

    void ChangeEffect()
    {
        this.gameObject.transform.GetChild(4).transform.GetComponent<TextMeshProUGUI>().text = abillity.abillitySO.currentValue.ToString();
    }


}
