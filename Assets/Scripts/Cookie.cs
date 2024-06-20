using UnityEngine;

public class Cookie : MonoBehaviour
{
    

    private void Awake() 
    {

    }
    public void Click()
    {
        DataManager.Instance.money += DataManager.Instance.upgrade;
    }
}