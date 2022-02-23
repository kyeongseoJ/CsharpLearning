using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //사용자에게 정수 2개와 기호(+,-,*,/,%)를 입력받아 결과값이 나오는 계산기를 만들어주세요.
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
