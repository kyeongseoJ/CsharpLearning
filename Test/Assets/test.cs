using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //����ڿ��� ���� 2���� ��ȣ(+,-,*,/,%)�� �Է¹޾� ������� ������ ���⸦ ������ּ���.
        string userInput1 = "10";
        string userInput2 = "2";
        string userInput3 = "/";

        int num1 = int.Parse(userInput1);
        int num2 = int.Parse(userInput2);
        int value = 0;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
