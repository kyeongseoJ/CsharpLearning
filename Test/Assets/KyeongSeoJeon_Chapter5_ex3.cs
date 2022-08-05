using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeongSeoJeon_Chapter5_ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "0";
        int num = int.Parse(userInput);

        if (num == 0)
        {
            Debug.Log($"{num}(은)는3의 배수가 아닙니다.");
        }
        else
        {
        string result = (num % 3 == 0) ? $"{num}(은)는 3의 배수입니다." : $"{num}(은)는3의 배수가 아닙니다.";
            Debug.Log(result);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
