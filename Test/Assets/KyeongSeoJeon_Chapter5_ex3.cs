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
            Debug.Log($"{num}(��)��3�� ����� �ƴմϴ�.");
        }
        else
        {
        string result = (num % 3 == 0) ? $"{num}(��)�� 3�� ����Դϴ�." : $"{num}(��)��3�� ����� �ƴմϴ�.";
            Debug.Log(result);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
