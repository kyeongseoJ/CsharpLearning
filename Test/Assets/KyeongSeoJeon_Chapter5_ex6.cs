using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeongSeoJeon_Chapter5_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //사용자에게 정수 2개와 기호(+,-,*,/,%)를 입력받아 결과값이 나오는 계산기를 만들어주세요.
        string userInput1 = "100";
        string userInput2 = "23";
        string userInput3 = "*";

        int num1 = int.Parse(userInput1);
        int num2 = int.Parse(userInput2);
        int value = 0;

        // Zero Division Error는 어떻게 작성..?

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
                Debug.Log($"입력하신 {userInput1}{userInput3}{userInput2}의 값은 {value}입니다");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
