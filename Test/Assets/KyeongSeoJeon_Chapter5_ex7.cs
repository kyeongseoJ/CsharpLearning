using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeongSeoJeon_Chapter5_ex7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�� ���� ���� �Ѵް��� ��¥ ���� �˷��ִ� ���α׷��� ������ּ���.

        string userInput = "7";
        int input = int.Parse(userInput);
        int days = 0;

        // 31 = 1 3 5 7 8 10 12
        // 28 = 2
        // 30 = 4 6 9 11 
        switch(input)
        {
            case 2:
                days = 28;
                break;
            case 4:
                days = 30;
                break;
            case 1 :
                days = 31;
                break;
        }
        Debug.Log($"{input}��/�� {days}���� �ֽ��ϴ�. ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
