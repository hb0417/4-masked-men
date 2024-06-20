using UnityEngine;

public class Cookie : MonoBehaviour
{
    

    private void Awake() 
    {

    }
    public void Click()
    {
        GameManager.Instance.money += GameManager.Instance.upgrade;
    }
}