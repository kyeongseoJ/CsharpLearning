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

        //char a = '��'; char b = '��'; char c = '��'; char d = '��'; char e = '��';

        //Debug.Log($"{a}{b}{c}{d}{e}");
        ////�ڹٽ�ũ��Ʈ ��� ? ��ƽ ��� �ȉ�
        ////Debug.Log(`${ a, b, c, d, e}`);
        //Debug.Log('a' + 'b' + 'c' + 'd' + 'e'); // 495 ��� ���� => �����ڵ� ���� ���Ǽ� ����
        //Debug.Log($"{a + b + c + d + e}"); // 250817 �̶�� ����
        ////�ذ���: ���ڿ��� �������ָ� �����Ϸ��� ���ڷ� ����
        //Debug.Log("" + a + b + c + d + e); //�ȳ��ϼ���

        //string a = "�ȳ��ϼ���?";
        //string b = "���漭 �Դϴ�.";

        //Debug.Log(a);
        //Debug.Log(b);

        //Debug.Log($"{a + b}");
        //Debug.Log($"{a}" + $"{b}"); //���� ���๮�� ���� ��� �ִ���... \s, \n ����ǥ�ó� => �����ȉ�

        //bool a = true;
        //bool b = false;

        //Debug.Log(a); // True = 1
        //Debug.Log(b); // False = 0

        //string c = "rudtj"; // ������ alt + F12

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
