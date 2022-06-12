using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] int speed;

    [SerializeField] Rigidbody rb;
    [SerializeField] private Vector3 position;
    

    void Awake()
    {
        rb = GetComponent<Rigidbody>();        
    }

    void Start()
    {
        position = transform.position;    
    }
    void Update()
    {
        position = transform.position;
        position.z = Mathf.Clamp(position.z, -29, 29);
        transform.position = position;
       
    }


    public void MoveRight()
    {
        rb.velocity = new Vector3(0, 0, -speed);
    }


    public void MoveLeft()
    {
        rb.velocity = new Vector3(0, 0, speed);
    }

    public void SetVelocityZero()
    {
        rb.velocity = Vector3.zero;
    }





}
