using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void retry()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        Time.timeScale = 1;
        SceneManager.LoadScene(activeScene.name);
    }
}
