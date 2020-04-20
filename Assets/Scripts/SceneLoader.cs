using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadNextScene(){

        // Getting the currently active scene, find its buildIndex
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

}
