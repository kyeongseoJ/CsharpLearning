using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter6 : MonoBehaviour
{
    // Start is called before the first frame update
  
        // Method �޼��� : ���� ����� �ϳ��� �̸����� ������� ��
        // class Ŭ���� �̸�(�빮�ڷ� ������ ��)
        // ������ ��ȯ���� �޼ҵ� �̸�(�Ű����� ���)
        // {�����ϰ��� �ϴ� �ڵ�(���)
        // return �޼ҵ� ���==> ��ȯ�Ѵٴ� �ǹ� �״����
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
