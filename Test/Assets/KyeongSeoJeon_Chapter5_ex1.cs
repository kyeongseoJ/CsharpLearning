using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeongSeoJeon_Chapter5_ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ���� �ȳ� ���α׷� �����
            // ������� ������ �Է¹޾� 90�� �̻��� ��A��,
            // 80�� �̻��� ��B��, 70�� �̻��� ��C��, 69�� ���� ������ ��F��
            // �� ��µǴ� ���α׷��� ����� �ּ���.
        string userInput = "88";
        string score = "";
        int number = int.Parse(userInput);
        if (90 <= number)
        {
            score = "A";
            Debug.Log($"�Է��Ͻ� ������ {number}���� {score}�����Դϴ�.");
        }
        else if (80 <= number && number < 90)
        {
            score = "B";
            Debug.Log($"�Է��Ͻ� ������ {number}���� {score}�����Դϴ�..");
        }
        else if (70 <= number && number < 80)
        {
            score = "C";
            Debug.Log($"�Է��Ͻ� ������ {number}���� {score}�����Դϴ�..");
        }
       //  else if (70 <= number < 80) ������ �ۼ��ϸ� ������       
        else
        {
            score = "F";
            Debug.Log($"�Է��Ͻ� ������ {number}���� {score}�����Դϴ�..");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
