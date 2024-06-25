using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//여현빈 미완성
//배경음, 효과음
public class SoundManager : MonoBehaviour
{

    public GameObject particlePrefab; // 파티클 시스템 프리팹을 할당할 변수

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 왼쪽 버튼 클릭 감지
        if (Input.GetMouseButtonDown(0))
        {
            // 카메라의 월드 좌표로 마우스 위치를 변환
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // Z 좌표를 0으로 설정하여 2D 평면에 맞춤

            // 파티클 시스템 생성
            Instantiate(particlePrefab, mousePosition, Quaternion.identity);
        }
    }
}
