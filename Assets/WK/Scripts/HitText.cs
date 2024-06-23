using System.Collections;
using TMPro;
using UnityEngine;

public class HitText : MonoBehaviour
{
    //활성화
    //text 수정 
    //위치 수정
    //애니메이션 실행
    //셋액티브 끄기 
    private static readonly int isHit = Animator.StringToHash("isHit");

    [SerializeField] private Animator textAnim;
    [SerializeField] private TextMeshProUGUI hitTxt;
    private Transform spawnPosition;

    private float ranNumX;
    private float ranNumY;

    private void Awake()
    {
        spawnPosition = GetComponent<Transform>();
        textAnim = GetComponent<Animator>();
    }
    
    public void HitTextEnter(float value)
    {
        TextRandomPosition();
        ChangeText(value);
        Hit();
        StartCoroutine(SetOffText());
    }

    private void TextRandomPosition()
    {
        ranNumX = Random.Range(0f, 3f);
        ranNumY = Random.Range(-3f, 3f);

        spawnPosition.localPosition = new Vector2(ranNumX, ranNumY);
    }

    private void ChangeText(float value)
    {
        int i = (int)value;
        hitTxt.text = i.ToString();
    }

    private void Hit()
    {
        textAnim.SetTrigger(isHit);
    }

    private IEnumerator SetOffText()
    {
        yield return new WaitForSeconds(0.3f);
        gameObject.SetActive(false);
    }
}
