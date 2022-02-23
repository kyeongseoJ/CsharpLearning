using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter3 : MonoBehaviour
{
    enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
    // Start is called before the first frame updateS
    void Start()
    {
        //int a = -10;
        //int b = 40;

        //Debug.Log("a = " + a + ", b = " + b);
        //Debug.Log($"a = {a}, b = {b}");

        //float a = 3.14159265358979323846f;
        //double b = 3.14159265358979323846;

        //Debug.Log("a = " + a + ", b = " + b);
        //Debug.Log($" a = {a}, b = {b}");

        //char a = '안'; char b = '녕'; char c = '하'; char d = '세'; char e = '요';

        //Debug.Log($"{a}{b}{c}{d}{e}");
        ////자바스크립트 방식 ? 백틱 사용 안됌
        ////Debug.Log(`${ a, b, c, d, e}`);
        //Debug.Log('a' + 'b' + 'c' + 'd' + 'e'); // 495 라고 나옴 => 유니코드 값이 계산되서 나옴
        //Debug.Log($"{a + b + c + d + e}"); // 250817 이라고 나옴
        ////해결방법: 문자열로 시작해주면 컴파일러가 문자로 읽음
        //Debug.Log("" + a + b + c + d + e); //안녕하세요

        //string a = "안녕하세요?";
        //string b = "전경서 입니다.";

        //Debug.Log(a);
        //Debug.Log(b);

        //Debug.Log($"{a + b}");
        //Debug.Log($"{a}" + $"{b}"); //띄어쓰기 개행문자 적용 어떻게 넣는지... \s, \n 에러표시남 => 지원안됌

        //bool a = true;
        //bool b = false;

        //Debug.Log(a); // True = 1
        //Debug.Log(b); // False = 0

        //string c = "rudtj"; // 추적점 alt + F12

        //float a = 0.9f;
        //float b = (int)a;
        //Debug.Log(b); //0

        //float c = 1.1f;
        //float d = (int)c;
        //Debug.Log(d); //1

        //int a = 123;
        //string b = a.ToString();
        //Debug.Log(b);

        //float c = 3.14f;
        //string d = c.ToString();
        //Debug.Log(d);

        //string e = "123456";
        //int f = int.Parse(e);
        //Debug.Log(f);

        //string g = "1.2345";
        //float h = float.Parse(g);
        //Debug.Log(h);

        //const int MAX_INT = 2147483647;
        //const int MIN_INT = -2147483648;

        //Debug.Log(MAX_INT);
        //Debug.Log(MIN_INT);

        //int a = 100;
        //Debug.Log(a);

        //a = 1;
        //Debug.Log(a);

        //a = 35;
        //Debug.Log(a);

        Debug.Log((int)DialogResult.YES);
        Debug.Log((int)DialogResult.NO);
        Debug.Log((int)DialogResult.CANCEL);
        Debug.Log((int)DialogResult.CONFIRM);
        Debug.Log((int)DialogResult.OK);

        DialogResult result = DialogResult.YES;

        Debug.Log(result == DialogResult.YES);
        Debug.Log(result == DialogResult.NO);
        Debug.Log(result == DialogResult.CANCEL);
        Debug.Log(result == DialogResult.CONFIRM);
        Debug.Log(result == DialogResult.OK);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
