using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollectible : MonoBehaviour
{
    [SerializeField] public int value;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            FindObjectOfType<AudioManager>().Play("LightCoin");
    }

}

