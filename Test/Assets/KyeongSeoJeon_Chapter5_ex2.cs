using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeongSeoJeon_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "55";
        int num = int.Parse(userInput);

        string result = (50 <= num) ? "50이상" : "50미만";
        Debug.Log(result);

        if ( 50 <= num )
        {
            Debug.Log("50이상입니다.");
        }
        else
        {
            Debug.Log("50미만입니다.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
