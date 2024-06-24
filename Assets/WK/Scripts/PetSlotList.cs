using UnityEngine;

public class PetSlotList : MonoBehaviour //WK
{
    private Transform thisTransform;

    [SerializeField] private PetSlot petSlot;
    [SerializeField] private Pet[] pets;

    private void Awake()
    {
        thisTransform = GetComponent<Transform>();

        if(pets != null)
        {
            for (int i = 0; i < pets.Length; i++)
            {
                PetSlot newSlot = Instantiate(petSlot, thisTransform);
                petSlot.thisSlotPet = pets[i];
            }
        }
    }
}