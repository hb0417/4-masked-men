using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PetSlot : MonoBehaviour // WK
{
    [HideInInspector] public Pet thisSlotPet;

    public Image petIcon;
    public TextMeshProUGUI petNameTxt;
    public TextMeshProUGUI petCostTxt;
    public TextMeshProUGUI buttonTxt;
    public Button purchaseButton;

    public Outline outline;

    private void Start()
    {
        outline.enabled = false;

        if (thisSlotPet != null)
        {
            petIcon.sprite = thisSlotPet.icon;
            petNameTxt.text = thisSlotPet.petName;
            petCostTxt.text = thisSlotPet.petCost.ToString("F2");
        }
    }

    public void OnPurchasePet()
    {
        Instantiate(thisSlotPet);
        buttonTxt.text = "구매완료";
        outline.enabled = true;
        purchaseButton.enabled = false;
    }
}
