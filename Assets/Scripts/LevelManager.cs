using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    LevelManager levelManager;
    GameObject mainCamera;

    private void Start()
    {
        levelManager = GetComponent<LevelManager>();
        LevelManager.DontDestroyOnLoad(levelManager);
    } 

    public void LoadMainScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadStartScene ()
    {
        SceneManager.LoadScene(0);
    }
}
