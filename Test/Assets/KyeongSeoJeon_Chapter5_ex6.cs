using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeongSeoJeon_Chapter5_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //����ڿ��� ���� 2���� ��ȣ(+,-,*,/,%)�� �Է¹޾� ������� ������ ���⸦ ������ּ���.
        string userInput1 = "100";
        string userInput2 = "23";
        string userInput3 = "*";

        int num1 = int.Parse(userInput1);
        int num2 = int.Parse(userInput2);
        int value = 0;

        // Zero Division Error�� ��� �ۼ�..?

        switch (userInput3)
        {
            case "+":
                value = num1 + num2;
                break;
            case "-":
                value = num1 - num2;
                break;
            case "*":
                value = num1 * num2;
                break;
            case "/":
                value = num1 / num2;
                break;
            case "%":
                value = num1 % num2;
                break;     
        }
                Debug.Log($"�Է��Ͻ� {userInput1}{userInput3}{userInput2}�� ���� {value}�Դϴ�");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
