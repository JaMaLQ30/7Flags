using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportScene : MonoBehaviour
{
    public string targetSceneName; // «”„ «·”Ì‰ «·„” Âœ›

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(targetSceneName); //  Õ„Ì· «·”Ì‰ «·„” Âœ›
        }
    }
}