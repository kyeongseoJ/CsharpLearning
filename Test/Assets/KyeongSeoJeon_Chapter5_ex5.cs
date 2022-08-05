using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeongSeoJeon_Chapter5_ex5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //광주초등학교에서 1학년부터 4학년까지 중간고사 시험을 보았다.
        //4학년은 70점 이상이면 합격, 그 이외의 학년은 60점 이상이면 합격이다.
        //이를 판단하는 프로그램을 만들어주세요. 점수가 0미만 100초과이면 경고문구 출력!

        string userGrade = "4학년";
        string userInput = "45";
        int userScore = int.Parse(userInput);

        if (userGrade == "4학년")
        {
            string result = (userScore >= 70)? "합격" : "불합격";
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
