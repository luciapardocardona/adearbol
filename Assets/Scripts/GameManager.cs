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

    string famScore = "famScore";
    string friendScore = "friendScore";
    string moleScore = "moleScore";

    Scene currentScene;
    Animator myAnimator;
    AudioSource sound;
    private string nextScene;
    PlayerScript playerScript;
    PlayerMovement playerMovement;

    private void Awake()
    {
        GameObject gameObject = GameObject.Find("Squirrel");

        currentScene = SceneManager.GetActiveScene();

        playerScript = gameObject.GetComponent<PlayerScript>();
        playerMovement = gameObject.GetComponent<PlayerMovement>();
        sound = GetComponent<AudioSource>();

        if (PlayerPrefs.GetInt("fromVillage") == 0)
        {
            gameObject.GetComponent<Rigidbody2D>().transform.position.Set(6, -3.2f, 0);
        }
    }

    private void Update()
    {
        if (dayCount == 4)
        {
            var masmenos = 10;
            var rango = 15;
            var percentageFamily = PlayerPrefs.GetInt(famScore) / 7f * 100;
            var percentageFriend = PlayerPrefs.GetInt(friendScore) / 7f * 100;
            var percentageMole = PlayerPrefs.GetInt(moleScore) / 7f * 100;

            if (percentageFamily - masmenos > 100 - rango) // 1
            {
                // final fam 100%
            }
            else if (percentageFriend - masmenos > 100 - rango) // 2
            {
                // final friend 100%
            }
            else if (percentageMole - masmenos > 100 - rango) // 3
            {
                // final mole 100%
            }
            else if (percentageFamily - masmenos > 75 - rango) //4
            {
                // final fam 75 y friend 25
            }
            else if (percentageMole - masmenos > 75 - rango) //5
            {
                // final mole 75 y friend 25
            }
            else if (percentageFriend - masmenos > 50 - rango && percentageMole - masmenos > 50 - rango) //6
            {
                // final friend 50% y 50% mole
            }
            else if (percentageFamily - masmenos > 50 - rango && percentageMole - masmenos > 50 - rango) // 7
            {
                // final fam 50 y mole 50
            }
            else if (percentageFamily - masmenos > 35 - rango && percentageFriend - masmenos > 35 - rango && percentageMole - masmenos > 35 - rango) //8
            {
                // final todos 33
            }
            else //9
            {
                // final todos mal
            }
        }
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
                    this.GoToNextScene(true);
                }
                break;

        }
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void GoToNextScene(bool fromVillage = false)
    {
        if (fromVillage)
        {
            PlayerPrefs.SetInt("fromVillage", 0);
        }
        SceneManager.LoadScene(this.nextScene);
    }

    public string QuestionChooser()
    {
        var text = String.Empty;

        switch (currentScene.name)
        {
            case SceneConstants.Home:
                text = WinningOption() == EPeople.family ? dialogs[dayCount].questions.positive.family : dialogs[dayCount].questions.negative.family;
                break;
            case SceneConstants.Out:
                text = WinningOption() == EPeople.mole ? dialogs[dayCount].questions.positive.mole : dialogs[dayCount].questions.negative.mole;
                break;
            case SceneConstants.Village:
                text = WinningOption() == EPeople.friend ? dialogs[dayCount].questions.positive.friend : dialogs[dayCount].questions.negative.friend;
                break;
        }
        return text;
    }

    private EPeople WinningOption()
    {

        var fam = PlayerPrefs.GetInt(famScore);
        var friend = PlayerPrefs.GetInt(friendScore);
        var mole = PlayerPrefs.GetInt(moleScore);

        if (fam > friend && fam > mole)
        {
            return EPeople.family;
        }
        else if (mole > friend && mole > fam)
        {
            return EPeople.mole;
        }
        else
        {
            return EPeople.friend;
        }

    }

    public string AnswerChooser(bool hasAccepted)
    {
        var text = String.Empty;

        switch (currentScene.name)
        {
            case SceneConstants.Home:
                if (hasAccepted)
                {
                    text = dialogs[dayCount].npcAnswers.positive.family;

                    var score = PlayerPrefs.GetInt(famScore);
                    score += (dayCount == 1 || dayCount == 4) ? 2 : 1;
                    PlayerPrefs.SetInt(famScore, score);

                    dayCount++;
                }
                else
                {
                    text = dialogs[dayCount].npcAnswers.negative.family;
                }
                break;
            case SceneConstants.Village:
                if (hasAccepted)
                {
                    text = dialogs[dayCount].npcAnswers.positive.friend;

                    var score = PlayerPrefs.GetInt(friendScore);
                    score += (dayCount == 1 || dayCount == 4) ? 2 : 1;
                    PlayerPrefs.SetInt(friendScore, score);

                    dayCount++;
                }
                else
                {
                    text = dialogs[dayCount].npcAnswers.negative.friend;
                }
                break;
            case SceneConstants.Out:
                if (hasAccepted)
                {
                    text = dialogs[dayCount].npcAnswers.positive.mole;

                    var score = PlayerPrefs.GetInt(moleScore);
                    score += (dayCount == 1 || dayCount == 4) ? 2 : 1;
                    PlayerPrefs.SetInt(moleScore, score);

                    dayCount++;
                }
                else
                {
                    text = dialogs[dayCount].npcAnswers.negative.mole;
                }
                break;
        }
        return text;
    }
}
