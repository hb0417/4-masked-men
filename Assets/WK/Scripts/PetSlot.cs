using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PetSlot : MonoBehaviour
{
    public Pet thisSlotPet;

    public Image petIcon;
    public TextMeshProUGUI petNameTxt;
    public TextMeshProUGUI petCostTxt;

    private void Start()
    {
        if(thisSlotPet != null)
        {
            petIcon.sprite = thisSlotPet.icon;
            petNameTxt.text = thisSlotPet.petName;
            petCostTxt.text = thisSlotPet.petCost.ToString("F2");
        }
    }

    public void OnPurchasePet()
    {
        Instantiate(thisSlotPet);
        this.enabled = false;
    }
}
