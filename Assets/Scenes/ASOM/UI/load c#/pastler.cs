using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pastler : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(7);
    }
}
