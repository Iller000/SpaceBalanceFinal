using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeadPlayer : MonoBehaviour
{
    public IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            StartCoroutine(WaitForSceneLoad());
        }

            
    }
}
