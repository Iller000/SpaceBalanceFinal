using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkCollectible : MonoBehaviour
{
    [SerializeField] public int value;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            FindObjectOfType<AudioManager>().Play("DarkCoin");
    }
}    
