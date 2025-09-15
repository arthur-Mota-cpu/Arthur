using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dano : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
                 
            other.gameObject.GetComponent<Animator>().SetTrigger("Dano");

            DoDelayAction(0.5f);
            
        }
    }
    
    void DoDelayAction(float delayTime)
    {
        StartCoroutine(DelayAction(delayTime));
    }
    IEnumerator DelayAction(float delayTime)
    {
        //Wait for the specified delay time before continuing.
        yield return new WaitForSeconds(delayTime);
        //Do the action after the delay time has finished.
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);     
    }
    
}