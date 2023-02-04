using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    int dayCount = 0;
    List<Dialogs> dialogs = new List<Dialogs>{
        QuestionsConstants.day1,
        QuestionsConstants.day2,
        QuestionsConstants.day3,
        QuestionsConstants.day4,
        QuestionsConstants.day5
    };

    float famScore = 0f;
    float friendScore = 0f;
    float moleScore = 0f;
    bool hasAnswered = false;
    Scene currentScene;


    Animator myAnimator;
    AudioSource sound;

    private string nextScene;
    public AudioClip soundWoodDoor, soundMetalDoor;

    public TextMeshProUGUI npcQuestionText;
    public GameObject player;

    PlayerScript playerScript;
    private void Awake()
    {
        GameObject gameObject = GameObject.Find("Squirrel");
        player = GameObject.Find("Squirrel");
        player = GameObject.Find("NPC");

        currentScene = SceneManager.GetActiveScene();

        playerScript = gameObject.GetComponent<PlayerScript>();
        sound = GetComponent<AudioSource>();
        QuestionChooser();
        AnswerChooser();
    }

    public void HandleSceneTransition()
    {
         var currentScene = SceneManager.GetActiveScene();

         switch (currentScene.name)
         {
          case SceneConstants.Home:
                if (playerScript.isPlayerTouchingDoor)
                {
                    this.nextScene = SceneConstants.Out;
                    this.GoToNextScene();
                }
               break;
           case SceneConstants.Out:
                if (playerScript.isPlayerTouchingDoor)
                {
                    this.nextScene = SceneConstants.Home;
                    this.GoToNextScene();
                }
                else if (this.playerScript.isPlayerOnPath)
                {
                    this.nextScene = SceneConstants.Village;
                    this.GoToNextScene();
                };
                break;
           case SceneConstants.Village:
                if (playerScript.isPlayerOnPath)
                {
                    this.nextScene = SceneConstants.Out;
                    this.GoToNextScene();
                }
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

    private void QuestionChooser(bool reading = false)
    {
        if (reading)
        {
            // dialog has appeared
            // TODO: lucia things
        }
        else
        {
            // dialog has to appear
            var texto = "";

            switch (currentScene.name)
            {
                case SceneConstants.Home:
                    texto = WinningOption() == 0 ? dialogs[dayCount].questions.positive.family : dialogs[dayCount].questions.negative.family;
                    break;
                case SceneConstants.Village:
                    texto = WinningOption() == 1 ? dialogs[dayCount].questions.positive.mole : dialogs[dayCount].questions.negative.mole;
                    break;
                case SceneConstants.Out:
                    texto = WinningOption() == 2 ? dialogs[dayCount].questions.positive.friend : dialogs[dayCount].questions.negative.friend;
                    break;
            }
            //npcQuestionText.SetText(texto);
        }
    }
    

    private int WinningOption()
    {
        if (famScore > friendScore && famScore > moleScore)
        {
            return 0;
        }
        else if (moleScore > friendScore && moleScore > famScore)
        {
            return 1;
        }
        else
        {
            return 2;
        }

    }

    private void AnswerChooser()
    {
        var texto = "";

        switch (currentScene.name)
        {
            case SceneConstants.Home:
                texto = WinningOption() == 0 ? dialogs[dayCount].npcAnswers.positive.family : dialogs[dayCount].npcAnswers.negative.family;
                break;
            case SceneConstants.Village:
                texto = WinningOption() == 1 ? dialogs[dayCount].npcAnswers.positive.mole : dialogs[dayCount].npcAnswers.negative.mole;
                break;
            case SceneConstants.Out:
                texto = WinningOption() == 2 ? dialogs[dayCount].npcAnswers.positive.friend : dialogs[dayCount].npcAnswers.negative.friend;
                break;
        }
       // npcQuestionText.SetText(texto);
    }
}
