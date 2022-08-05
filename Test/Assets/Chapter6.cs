using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter6 : MonoBehaviour
{
    // Start is called before the first frame update
  
        // Method 메서드 : 여러 기능을 하나의 이름으로 묶어놓은 것
        // class 클래스 이름(대문자로 시작할 것)
        // 한정자 변환형식 메소드 이름(매개변수 목록)
        // {실행하고자 하는 코드(블록)
        // return 메소드 결과==> 반환한다는 의미 그대로임
    class Calculater
    {
        public static int Plus(int a, int b)
        {
            Debug.Log($"input : {a},{b}");
            
            int result = a + b;
            return result;
        }
    }

    private void Start()
    {
    int result1 = Calculater.Plus(3, 4);
        Debug.Log(result1);
    int result2 = Calculater.Plus(5, 6);
        Debug.Log(result2);
    int result3 = Calculater.Plus(7, 8);
        Debug.Log(result3);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
