using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager: MonoBehaviour
{
    [SerializeField] GameObject[] objects;
    [SerializeField] Vector3 spawnValues;
    [SerializeField] float spawnWait;
    [SerializeField] float spawnMostWait;
    [SerializeField] float spawnLeastWait;
    [SerializeField] int startWait;
    [SerializeField] bool stop;
    [SerializeField] int randomObjects;
   

    void Start()
    {
        StartCoroutine(Spawner());
        
    }
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
        
       
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(startWait); 

        while (!stop)
        {
            randomObjects = Random.Range(0, 3);
            Vector3 spawnPosition = new Vector3(1, 1, Random.Range(-spawnValues.z, spawnValues.z));

            Instantiate(objects[randomObjects], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            

            yield return new WaitForSeconds(spawnWait);

            
        }
    }
    


 

   



} 
