using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_Saetze : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ���� ����� �Է��� �޴� ���� ���ڿ��� ������ ������ ����ȯ ������ ���ľ� �Ѵ�.
        string userInput0 = "string�Դϴ�.";
        int num0 = int.Parse(userInput0);

        // ���ǿ��깮 ���� ������ ���� ��� �Ǻ�
        int userInput = -33;
        string result = (userInput > 0 && userInput!= 0) ? "���" : "����";
        Debug.Log(result);

        // ���ǿ��깮 ���� ������ 2 ¦�� Ȧ��
        int userInput1 = 20;
        string result1 = userInput1 % 2 == 0 ? "¦��" : "Ȧ��";
        Debug.Log(result1);

        // ���ǿ��깮 ���� ������ 3 ����
        int age = 27;
        string result2 = 0 < age && age <= 20 ? "����" : "����";
        Debug.Log(result2);

        // ���ǿ��깮 ���� ������ 4 ��ø���ǹ� ���
        int num = 42;
        string result3 = num > 0 && num % 2 == 0 ? "0���� ū ¦��" : "0���� ū Ȧ��";
        string result4 = num < 0 ? "0���� �ۼ��� ���� ��" : "";
        Debug.Log(result3);
        Debug.Log(result4);

        //if�� ���� ������1
        int a = 3;
        int b = 8;
        if (a - b < 0)
        {
            Debug.Log("a�� b���� �۴�.");
        }
        else if(a - b == 0)
        {
            Debug.Log("a�� b�� ���� ����.");
        }
        else
        {
            Debug.Log("a�� b���� ũ��.");
        }

        // if�� ���� ������2
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
