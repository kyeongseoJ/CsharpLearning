using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeongSeoJeon_Chapter5_ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 학점 안내 프로그램 만들기
            // 사용자의 점수를 입력받아 90점 이상은 “A”,
            // 80점 이상은 “B”, 70점 이상은 “C”, 69점 이하 점수는 “F”
            // 가 출력되는 프로그램을 만들어 주세요.
        string userInput = "88";
        string score = "";
        int number = int.Parse(userInput);
        if (90 <= number)
        {
            score = "A";
            Debug.Log($"입력하신 점수는 {number}으로 {score}학점입니다.");
        }
        else if (80 <= number && number < 90)
        {
            score = "B";
            Debug.Log($"입력하신 점수는 {number}으로 {score}학점입니다..");
        }
        else if (70 <= number && number < 80)
        {
            score = "C";
            Debug.Log($"입력하신 점수는 {number}으로 {score}학점입니다..");
        }
       //  else if (70 <= number < 80) 범위로 작성하면 에러남       
        else
        {
            score = "F";
            Debug.Log($"입력하신 점수는 {number}으로 {score}학점입니다..");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
