using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_Saetze : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 원래 사용자 입력을 받는 수는 문자열로 들어오기 때문에 형변환 과정을 거쳐야 한다.
        string userInput0 = "string입니다.";
        int num0 = int.Parse(userInput0);

        // 조건연산문 예제 만들어보기 음수 양수 판별
        int userInput = -33;
        string result = (userInput > 0 && userInput!= 0) ? "양수" : "음수";
        Debug.Log(result);

        // 조건연산문 예제 만들어보기 2 짝수 홀수
        int userInput1 = 20;
        string result1 = userInput1 % 2 == 0 ? "짝수" : "홀수";
        Debug.Log(result1);

        // 조건연산문 예제 만들어보기 3 나이
        int age = 27;
        string result2 = 0 < age && age <= 20 ? "아이" : "성인";
        Debug.Log(result2);

        // 조건연산문 예제 만들어보기 4 중첩조건문 경우
        int num = 42;
        string result3 = num > 0 && num % 2 == 0 ? "0보다 큰 짝수" : "0보다 큰 홀수";
        string result4 = num < 0 ? "0보다 작서나 같은 수" : "";
        Debug.Log(result3);
        Debug.Log(result4);

        //if문 예제 만들어보기1
        int a = 3;
        int b = 8;
        if (a - b < 0)
        {
            Debug.Log("a가 b보다 작다.");
        }
        else if(a - b == 0)
        {
            Debug.Log("a와 b는 값이 같다.");
        }
        else
        {
            Debug.Log("a가 b보다 크다.");
        }

        // if문 예제 만들어보기2
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
