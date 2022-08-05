using UnityEngine;
using System;  // console 관련은 시스템 안에 있다.

public class p112_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int year = 2022;
        int b_year = 1996;
        Debug.Log("현재년도를 입력하세요.");
        Debug.Log($"{year}");
        Debug.Log("출생년도를 입력하세요.");
        Debug.Log($"{b_year}");
        Debug.Log($"나의 나이는 : {year - b_year + 1}");

        Console.ForegroundColor = ConsoleColor.Red;
        Debug.Log("(나의 나이는 만 나이가 아닌 한국식 나이로 나오게 해주세요.)");
        Console.ResetColor();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
