using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������ �̿ϼ�
//�����, ȿ����
public class SoundManager : MonoBehaviour
{

    public GameObject particlePrefab; // ��ƼŬ �ý��� �������� �Ҵ��� ����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���콺 ���� ��ư Ŭ�� ����
        if (Input.GetMouseButtonDown(0))
        {
            // ī�޶��� ���� ��ǥ�� ���콺 ��ġ�� ��ȯ
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // Z ��ǥ�� 0���� �����Ͽ� 2D ��鿡 ����

            // ��ƼŬ �ý��� ����
            Instantiate(particlePrefab, mousePosition, Quaternion.identity);
        }
    }
}
