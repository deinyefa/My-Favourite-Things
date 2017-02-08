using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public void LoadMainScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadStartScene ()
    {
        SceneManager.LoadScene(0);
    }
}
