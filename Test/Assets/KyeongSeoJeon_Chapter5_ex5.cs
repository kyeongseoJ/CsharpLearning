using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeongSeoJeon_Chapter5_ex5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�����ʵ��б����� 1�г���� 4�г���� �߰���� ������ ���Ҵ�.
        //4�г��� 70�� �̻��̸� �հ�, �� �̿��� �г��� 60�� �̻��̸� �հ��̴�.
        //�̸� �Ǵ��ϴ� ���α׷��� ������ּ���. ������ 0�̸� 100�ʰ��̸� ����� ���!

        string userGrade = "4�г�";
        string userInput = "45";
        int userScore = int.Parse(userInput);

        if (userGrade == "4�г�")
        {
            string result = (userScore >= 70)? "�հ�" : "���հ�";
        }
        else
        {

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
