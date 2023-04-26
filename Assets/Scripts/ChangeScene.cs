using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    public void BackToBegining()
    {
        SceneManager.LoadScene("Begining", LoadSceneMode.Single);
    }

    public void Stop()
    {
        Application.Quit();
    }
    public void nextScene() 
    {
        SceneManager.LoadScene("Ui Elementi", LoadSceneMode.Additive);
    }
}
