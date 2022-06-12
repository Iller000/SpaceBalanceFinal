using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float rotation;

    
    void Update()
    {
        transform.Rotate(Vector3.right,
           rotation * Time.deltaTime);
    }
}
