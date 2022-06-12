using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollectorBalance : MonoBehaviour
{
    public static int _score;
    
    void OnTriggerEnter(Collider other)
    {
        LightCollectible l = other.GetComponent<LightCollectible>();
        if (l != null)
        {
            _score += l.value;           
            ScoreManager.instance.Balance();
            
        }

        DarkCollectible d = other.GetComponent<DarkCollectible>();
        if (d != null)
        {
            _score += d.value;
            ScoreManager.instance.Balance();
            
        }

        if (_score <= -5 || _score >= 5)
        {
            
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("ZeroBalance");
            SceneManager.LoadScene(2);           
        }






    }
    


}
