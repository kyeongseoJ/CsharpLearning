using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeongSeoJeon_Chapter5_ex10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �ڡ١١١� 1 4
        // �ڡڡ١١� 2 3
        // �ڡڡڡ١� 3 2 
        // �ڡڡڡڡ� 4 1
        // �ڡڡڡڡ� 5 0
        
        for (int i = 0; i < 5; i++)
        {
            string star = "";
            for (int j = 0; j <= i; j++)
            {
                star += "��";
            }

            for (int k = 0; k + i < 4; k++)
            {
                star += "��";
            }
            Debug.Log(star);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
