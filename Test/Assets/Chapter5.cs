using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Chapter5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //// if, else �׸��� else if ���ǹ�(�б⹮)
        //string userInput = "27";

        //int number = int.Parse(userInput);

        //if(number < 0)
        //{
        //    Debug.Log("����");
        //}
        //else if(number > 0)
        //{
        //    Debug.Log("���");
        //}
        //else
        //{
        //    Debug.Log("0");
        //}
        //// ù��° ���ǹ� �� : ���

        //if(number % 2 ==0)
        //{
        //    Debug.Log("¦��");
        //}
        //else
        //{
        //    Debug.Log("Ȧ��");
        //}
        //// �ι�° ���ǹ� �� : Ȧ��

        //// ���ǿ����ڷ� Ȧ�� ¦�� �Ǻ��ϴ� �ڵ� ����� : ����
        //int number1 = 28;
        //string result = (number1 % 2) == 0 ? "¦��" : "Ȧ��";
        //Debug.Log(result);

        //// if �� ��ø�ؼ� ����ϱ�
        //string userInput2 = "27";

        //int number2 = int.Parse(userInput2);
        //if (number2 > 0)
        //{
        //    if (number2 % 2 == 0)
        //    {
        //        Debug.Log("0���� ū ¦��.");
        //    }
        //    else
        //    {
        //        Debug.Log("0���� ū Ȧ��.");
        //    }
        //}
        //else
        //{
        //    Debug.Log("0���� �۰ų� ���� ��.");
        //}
        //// ��ø���ǹ��� �� : 0���� ū Ȧ��.

        //string day = "��";
        //switch (day)
        //{
        //    case "��":
        //        Debug.Log("Sunday");
        //        break;
        //    case "��":
        //        Debug.Log("Monday");
        //        break;
        //    case "ȭ":
        //        Debug.Log("Tuesday");
        //        break;
        //    case "��":
        //        Debug.Log("Wednesday");
        //        break;
        //    case "��":
        //        Debug.Log("Thursday");
        //        break;
        //    case "��":
        //        Debug.Log("Friday");
        //        break;
        //    case "��":
        //        Debug.Log("Saturday");
        //        break;
        //    default:
        //        Debug.Log($"{day}��(��) ������ �ƴմϴ�.");
        //        break;
        //}

        //int i = 10;

        //while (i > 0)
        //{
        //    Debug.Log($" i : {i--}");
        //    // 10 , 9, 8, 7, 6, 5, 4, 3, 2, 1
        //}
        //int i = 3;

        //do
        //{
        //    Debug.Log($" a) i : {i--}");
        //} // 3, 2, 1
        //while (i > 0);

        //// ���� �Ŀ��� 0 ���� �ȳ��´� �ѹ��� do while���� �����ϸ� ������
        ////�ѹ��� �����ϱ� ������ 0���� ������ ���� Ȯ���� �� �ִ�.
        //do
        //{
        //    Debug.Log($" b) {i--}");
        //} // 0
        //while (i > 0);

        ////�ݺ���
        //for (int i = 0; i < 5; i++)
        //{
        //    Debug.Log(i);  // 0,1,2,3,4
        //}

        //// �ݺ���
        //for (int i = 0; i < 5; i++) // 0, 1, 2, 3, 4
        //{
        //    for (int j = 0; j <= i; j++)
        //    {
        //        Debug.Log("*"); // *(0-0), *(0-1) *(1-1), *(0-2) *(1-2) *(2-2),
        //                        // *(0-3) *(1-3) *(2-3) *(3-3), *(0-4) *(1-4) *(2-4) *(3-4) *(4-4)
        //    }
        //}


        ////�迭 �ۼ���� 

        //// �л� ���� 5���� �б��� ������ ������ ����
        //int student01 = 90;
        //int student02 = 80;
        //int student03 = 70;
        //int student04 = 60;
        //int student05 = 50;

        //int[] stundent = new int[5]; // new = ������ Ű����
        //// ���� �ʱ�ȭ 
        //student01 = 90;
        //student02 = 80;
        //student03 = 70;
        //student04 = 60;
        //student05 = 50;

        // ����������[] �迭�̸� = new ����������[�뷮]{�����ʱ�ȭ}
        //int[] student = new int[] { 90, 80, 70, 60, 50 };

        //  foreach (���������� ������ in �迭 �Ǵ� �÷���) { �ڵ� �Ǵ� �ڵ���}
        //  �� ��   �� ��   ��
        //| 80 | 70 | 60 | 50 | 40 | ��
        //| 0 | 1 | 2 | 3 | 4 | �ε���
        //    �� ��   �� ��   ��

        //int[] arr = new int[] { 0, 1, 2, 3, 4 };
        //foreach(int a in arr)
        //{
        //    Debug.Log(a); // 0, 1, 2, 3, 4
        //}

        //// ������ : break, continue, goto , return, throw
        //// break : ���� �������� �ݺ����̳� switch ���� ������ �ߴ��ϰ��� �� �� ���
        //int i = 0;
        //while (i >= 0)
        //{
        //    // i�� 10�� �Ǹ� �ݺ��� ����.
        //    if (i == 10)
        //        break; // �ߴܽ�Ű���� �ϴ� ������ �Է�

        //    // i�� 10�� �Ǳ� ������ �ݺ��� ���ǽ� ����
        //    Debug.Log(i++);
        //}
        //Debug.Log("Prison Break");
        //// 0 1 2 3 4 5 6 7 8 9  Prison Break

        //// continue : �� ȸ �ǳʶپ� �ݺ��� ��� �����ϰ� �ϴ� ���
        //for (int i=0; i < 5; i++){
        //    if (i == 3)
        //        continue; // i�� 3�� ��� �������� �ݺ��� �ǳʶڴ�.
        //    Debug.Log(i); // 0 1 2 4 
        //}

        //// for�ݺ��� + if���ǹ� + ������
        //for (int i = 0; i < 10; i++){
        //    if(i % 2 == 0) // ¦�� �϶� �ǳʶٱ�
        //        {
        //            continue;
        //        }
        //    Debug.Log($"{i}: Ȧ��"); 
        //    // 1 : Ȧ��, 3 : Ȧ��, 5 : Ȧ��, 7 : Ȧ��, 9 : Ȧ��
        //}

        Debug.Log("1");
        
        goto JUMP; // goto Ű���� ��� -> 23 �ǳʶٰ� ���̺� ������ ������ �̵�

        Debug.Log("2");
        Debug.Log("3");

        JUMP: // ���̺� ���� �ڵ常 ��µȴ�.
        Debug.Log("4");


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
