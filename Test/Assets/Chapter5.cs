using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Chapter5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //// if, else 그리고 else if 조건문(분기문)
        //string userInput = "27";

        //int number = int.Parse(userInput);

        //if(number < 0)
        //{
        //    Debug.Log("음수");
        //}
        //else if(number > 0)
        //{
        //    Debug.Log("양수");
        //}
        //else
        //{
        //    Debug.Log("0");
        //}
        //// 첫번째 조건문 답 : 양수

        //if(number % 2 ==0)
        //{
        //    Debug.Log("짝수");
        //}
        //else
        //{
        //    Debug.Log("홀수");
        //}
        //// 두번째 조건문 답 : 홀수

        //// 조건연산자로 홀수 짝수 판별하는 코드 만들기 : 과제
        //int number1 = 28;
        //string result = (number1 % 2) == 0 ? "짝수" : "홀수";
        //Debug.Log(result);

        //// if 문 중첩해서 사용하기
        //string userInput2 = "27";

        //int number2 = int.Parse(userInput2);
        //if (number2 > 0)
        //{
        //    if (number2 % 2 == 0)
        //    {
        //        Debug.Log("0보다 큰 짝수.");
        //    }
        //    else
        //    {
        //        Debug.Log("0보다 큰 홀수.");
        //    }
        //}
        //else
        //{
        //    Debug.Log("0보다 작거나 같은 수.");
        //}
        //// 중첩조건문의 답 : 0보다 큰 홀수.

        //string day = "수";
        //switch (day)
        //{
        //    case "일":
        //        Debug.Log("Sunday");
        //        break;
        //    case "월":
        //        Debug.Log("Monday");
        //        break;
        //    case "화":
        //        Debug.Log("Tuesday");
        //        break;
        //    case "수":
        //        Debug.Log("Wednesday");
        //        break;
        //    case "목":
        //        Debug.Log("Thursday");
        //        break;
        //    case "금":
        //        Debug.Log("Friday");
        //        break;
        //    case "토":
        //        Debug.Log("Saturday");
        //        break;
        //    default:
        //        Debug.Log($"{day}는(은) 요일이 아닙니다.");
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

        //// 위의 식에선 0 값이 안나온다 한번더 do while문을 진행하면 어찌됬든
        ////한번은 실행하기 때문에 0까지 나오는 것을 확인할 수 있다.
        //do
        //{
        //    Debug.Log($" b) {i--}");
        //} // 0
        //while (i > 0);

        ////반복문
        //for (int i = 0; i < 5; i++)
        //{
        //    Debug.Log(i);  // 0,1,2,3,4
        //}

        //// 반복문
        //for (int i = 0; i < 5; i++) // 0, 1, 2, 3, 4
        //{
        //    for (int j = 0; j <= i; j++)
        //    {
        //        Debug.Log("*"); // *(0-0), *(0-1) *(1-1), *(0-2) *(1-2) *(2-2),
        //                        // *(0-3) *(1-3) *(2-3) *(3-3), *(0-4) *(1-4) *(2-4) *(3-4) *(4-4)
        //    }
        //}


        ////배열 작성방법 

        //// 학생 수가 5명인 학급의 성적을 변수로 선언
        //int student01 = 90;
        //int student02 = 80;
        //int student03 = 70;
        //int student04 = 60;
        //int student05 = 50;

        //int[] stundent = new int[5]; // new = 생성자 키워드
        //// 변수 초기화 
        //student01 = 90;
        //student02 = 80;
        //student03 = 70;
        //student04 = 60;
        //student05 = 50;

        // 데이터형식[] 배열이름 = new 데이터형식[용량]{변수초기화}
        //int[] student = new int[] { 90, 80, 70, 60, 50 };

        //  foreach (데이터형식 변수명 in 배열 또는 컬렉션) { 코드 또는 코드블록}
        //  ㅡ ㅡ   ㅡ ㅡ   ㅡ
        //| 80 | 70 | 60 | 50 | 40 | 값
        //| 0 | 1 | 2 | 3 | 4 | 인덱스
        //    ㅡ ㅡ   ㅡ ㅡ   ㅡ

        //int[] arr = new int[] { 0, 1, 2, 3, 4 };
        //foreach(int a in arr)
        //{
        //    Debug.Log(a); // 0, 1, 2, 3, 4
        //}

        //// 점프문 : break, continue, goto , return, throw
        //// break : 현재 실행중인 반복문이나 switch 문의 실행을 중단하고자 할 때 사용
        //int i = 0;
        //while (i >= 0)
        //{
        //    // i가 10이 되면 반복문 멈춤.
        //    if (i == 10)
        //        break; // 중단시키고자 하는 지점에 입력

        //    // i가 10이 되기 전까지 반복문 조건식 진행
        //    Debug.Log(i++);
        //}
        //Debug.Log("Prison Break");
        //// 0 1 2 3 4 5 6 7 8 9  Prison Break

        //// continue : 한 회 건너뛰어 반복을 계속 수행하게 하는 기능
        //for (int i=0; i < 5; i++){
        //    if (i == 3)
        //        continue; // i가 3일 경우 실행중인 반복을 건너뛴다.
        //    Debug.Log(i); // 0 1 2 4 
        //}

        //// for반복문 + if조건문 + 점프문
        //for (int i = 0; i < 10; i++){
        //    if(i % 2 == 0) // 짝수 일때 건너뛰기
        //        {
        //            continue;
        //        }
        //    Debug.Log($"{i}: 홀수"); 
        //    // 1 : 홀수, 3 : 홀수, 5 : 홀수, 7 : 홀수, 9 : 홀수
        //}

        Debug.Log("1");
        
        goto JUMP; // goto 키워드 사용 -> 23 건너뛰고 레이블 지정된 곳으로 이동

        Debug.Log("2");
        Debug.Log("3");

        JUMP: // 레이블 뒤의 코드만 출력된다.
        Debug.Log("4");


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
