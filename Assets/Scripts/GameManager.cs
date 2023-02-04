using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Animator myAnimator;
    AudioSource sound;

    private string nextScene;
    public AudioClip soundWoodDoor, soundMetalDoor;

    PlayerScript playerScript;
    private void Awake()
    {
        GameObject gameObject = GameObject.Find("Squirrel");

        playerScript = gameObject.GetComponent<PlayerScript>();
        sound = GetComponent<AudioSource>();
    }

    public void HandleSceneTransition()
    {
        var currentScene = SceneManager.GetActiveScene();

        switch (currentScene.name)
        {
            case SceneConstants.Home:

                Invoke(nameof(GoToNextScene), 2f);
                break;
            case SceneConstants.Out:
              
                break;
            case SceneConstants.Village:
                break;


    }
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void GoToNextScene()
    {
        SceneManager.LoadScene(this.nextScene);
    }
}
