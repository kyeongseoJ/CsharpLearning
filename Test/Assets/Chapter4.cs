using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int a = 111 + 222;
        //Debug.Log($"a : {a}");

        //int b = a - 100;
        //Debug.Log($"b : {b}");

        //int c = b * 10;
        //Debug.Log($"c : {c}");

        //float d = c / 6.3f;
        //Debug.Log($"d : {d}");

        //Debug.Log($"22 / 7 = {22 / 7}({22 % 7})");

        //int a = 10;
        //Debug.Log(a++); // 10
        //Debug.Log(++a); // 12

        //Debug.Log(a--); // 12
        //Debug.Log(--a); // 10

        //int b = 10;
        //Debug.Log(b--); // 10
        //Debug.Log(--b); // 8

        //int result = 111 + 222; // 333
        //string value = "333" + "444"; // 333444

        //Debug.Log(result);
        //Debug.Log(value);

        //Debug.Log($"3 > 4 : {3 > 4}"); // 3 > 4 False
        //Debug.Log($"3 >= 4 : {3 >= 4}"); // 3 >= 4 False
        //Debug.Log($"3 < 4 : {3 < 4}"); // True
        //Debug.Log($"3 <= 4 : {3 <= 4}"); // True
        //Debug.Log($"3 == 4 : {3 == 4}"); // False
        //Debug.Log($"3 != 4 : {3 != 4}"); // True

        //Debug.Log("Testing &&...");
        //Debug.Log($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}"); // t && t = True
        //Debug.Log($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}"); // t && f = False
        //Debug.Log($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}"); // f && f = False
        //Debug.Log($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}"); // f && t = False

        //Debug.Log("Testing ||...");
        //Debug.Log($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}"); // t || t = True
        //Debug.Log($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}"); // t || F = True
        //Debug.Log($"1 == 0 ||4 > 5 : {1 == 0 || 4 > 5}"); // f || f = False
        //Debug.Log($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}"); // f || t = True

        //Debug.Log("Testing ! ...");
        //Debug.Log($"!True : {!true}"); // False
        //Debug.Log($"!False : {!false}"); // True

        //string result = (10 % 2) == 0 ? "짝수" : "홀수";

        //Debug.Log(result); // 짝수

        //int a;
        //a = 100;
        //Debug.Log($"a = 100 : {a}"); //100
        //a += 90;
        //Debug.Log($"a+= 90 : {a}"); // 190
        //a -= 80;
        //Debug.Log($"a -= 80 : {a}"); // 110
        //a *= 70;
        //Debug.Log($"a *= 70 : {a}"); // 7700
        //a /= 60;
        //Debug.Log($"a /= 60 : {a}"); //128
        //a %= 50;
        //Debug.Log($"a %= 50 : {a}"); // 28

        int i = 1;
        Debug.Log(i = i + 1); 
            Debug.Log(i++); 
            Debug.Log(++i); 
            Debug.Log(i += 1); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
