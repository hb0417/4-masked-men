using System.Collections.Generic;
using UnityEngine;

public class ContainerHandler : MonoBehaviour
{
    public GameObject prefab;
    public RectTransform rectTransform;
    public List<AbillitySO> abillitySOList = new List<AbillitySO>();
    private GameObject generationObj;

    private void Awake() 
    {
        rectTransform = GetComponent<RectTransform>();    
    }

    private void Start()
    {

        for(int size = 0 ; size < abillitySOList.Count ; size++)
        {
            SetSizeContainer(size+1);
            generationObj = Instantiate(prefab, this.transform);
            SetAbillitySO(generationObj, abillitySOList[size]);
        }
        
    }

    void SetSizeContainer(int _size)
    {
        rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 100*(_size));
    }

    void SetAbillitySO(GameObject _generationObj,AbillitySO _abillitySO)
    {
        AbillityHandler abillityHandler = _generationObj.GetComponent<AbillityHandler>();

        abillityHandler.abillity.abillitySO = _abillitySO;
    }
    
}
