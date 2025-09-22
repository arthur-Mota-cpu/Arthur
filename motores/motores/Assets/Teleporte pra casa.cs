using UnityEngine;
using UnityEngine.SceneManagement;

public class Door: MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Casinha da raposinha");
        }
    }
}