using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeongSeoJeon_Chapter5_ex4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "54";
        string userInput2 = "78";
        string userInput3 = "123";

        int num1 = int.Parse(userInput1);
        int num2 = int.Parse(userInput2);
        int num3 = int.Parse(userInput3);

        int max, min;
        int total = num1 + num2 + num3;
        float avg = (num1 + num2 + num3) / 3;


        if (num1 > num2 && num1 > num3)
        {
            max = num1;
            if (num2 > num3)
            {
                min = num3;
            }
            else
            {
                min = num3;
            }
            Debug.Log($"최댓값은 {max}, 최솟값은 {min}이고 합계는 {total} 평균은 {avg}입니다.");
        }
        else if (num2 > num1 && num2 > num3)
        {
            max = num2;
            if (num1 > num3)
            {
                min = num3;
            }
            else
            {
                min = num1;
            }
            Debug.Log($"최댓값은 {max}, 최솟값은 {min}이고 합계는 {total} 평균은 {avg}입니다.");
        }
        else if (num3 > num1 && num3 > num2)
        {
            max = num3;
            if (num1 > num2)
            {
                min = num2;
            }
            else
            {
                min = num1;
            }
            Debug.Log($"최댓값은 {max}, 최솟값은 {min}이고 합계는 {total} 평균은 {avg}입니다.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
