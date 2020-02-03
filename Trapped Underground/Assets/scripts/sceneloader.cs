using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void SceneA1()
    {
        SceneManager.LoadScene("Situation A1");
    }
    public void SceneB1()
    {
        SceneManager.LoadScene("Situation B1");
    }
    public void endgame()
    {
        SceneManager.LoadScene("end");
    }
    public void SceneB2()
    {
        SceneManager.LoadScene("situation B2");
    }
    public void SceneVictory()
    {
        SceneManager.LoadScene("Victory Scene");
    }

}
