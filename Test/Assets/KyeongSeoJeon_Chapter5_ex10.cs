using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyeongSeoJeon_Chapter5_ex10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ★☆☆☆☆ 1 4
        // ★★☆☆☆ 2 3
        // ★★★☆☆ 3 2 
        // ★★★★☆ 4 1
        // ★★★★★ 5 0
        
        for (int i = 0; i < 5; i++)
        {
            string star = "";
            for (int j = 0; j <= i; j++)
            {
                star += "★";
            }

            for (int k = 0; k + i < 4; k++)
            {
                star += "☆";
            }
            Debug.Log(star);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
