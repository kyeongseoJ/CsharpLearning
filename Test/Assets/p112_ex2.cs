using UnityEngine;
using System;  // console ������ �ý��� �ȿ� �ִ�.

public class p112_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int year = 2022;
        int b_year = 1996;
        Debug.Log("����⵵�� �Է��ϼ���.");
        Debug.Log($"{year}");
        Debug.Log("����⵵�� �Է��ϼ���.");
        Debug.Log($"{b_year}");
        Debug.Log($"���� ���̴� : {year - b_year + 1}");

        Console.ForegroundColor = ConsoleColor.Red;
        Debug.Log("(���� ���̴� �� ���̰� �ƴ� �ѱ��� ���̷� ������ ���ּ���.)");
        Console.ResetColor();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
