using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeongSeoJeon_Chapter5_ex10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ¡Ú¡Ù¡Ù¡Ù¡Ù 1 4
        // ¡Ú¡Ú¡Ù¡Ù¡Ù 2 3
        // ¡Ú¡Ú¡Ú¡Ù¡Ù 3 2 
        // ¡Ú¡Ú¡Ú¡Ú¡Ù 4 1
        // ¡Ú¡Ú¡Ú¡Ú¡Ú 5 0
        
        for (int i = 0; i < 5; i++)
        {
            string star = "";
            for (int j = 0; j <= i; j++)
            {
                star += "¡Ú";
            }

            for (int k = 0; k + i < 4; k++)
            {
                star += "¡Ù";
            }
            Debug.Log(star);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
