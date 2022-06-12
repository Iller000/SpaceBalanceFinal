using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorPoints: MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        LightCollectible l = other.GetComponent<LightCollectible>();
        if (l != null)
        {           
            ScoreManager.instance.AddPoint();
                      
        }


        DarkCollectible d = other.GetComponent<DarkCollectible>();
        if (d != null)
        {
            ScoreManager.instance.AddPoint();
           
        }
       



    }


}
