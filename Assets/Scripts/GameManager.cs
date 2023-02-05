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

    [SerializeField] AudioClip[] dubbingQuestionsMole = Array.Empty<AudioClip>();
    [SerializeField] AudioClip[] dubbingQuestionsFam;
    [SerializeField] AudioClip[] dubbingQuestionsFriend;
    [SerializeField] AudioClip[] dubbingQuestionsNegativeMole = Array.Empty<AudioClip>();
    [SerializeField] AudioClip[] dubbingQuestionsNegativeFam;
    [SerializeField] AudioClip[] dubbingQuestionsNegativeFriend;
    [SerializeField] AudioClip[] dubbingAnswerPositiveMole;
    [SerializeField] AudioClip[] dubbingAnswerPositiveFam;
    [SerializeField] AudioClip[] dubbingAnswerPositiveFriend;
    [SerializeField] AudioClip[] dubbingAnswerNegativeMole;
    [SerializeField] AudioClip[] dubbingAnswerNegativeFam;
    [SerializeField] AudioClip[] dubbingAnswerNegativeFriend;

    string famScore = "famScore";
    string friendScore = "friendScore";
    string moleScore = "moleScore";
    string day = "dayCount";

    Scene currentScene;
    Animator myAnimator;
    AudioSource sound;
    private string nextScene;
    PlayerScript playerScript;
    PlayerMovement playerMovement;


    [SerializeField] GameObject signButton;
    [SerializeField] GameObject doorButton;

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene();


        dayCount = PlayerPrefs.GetInt(day, 0);

        if (dayCount == 4)
        {
            PercentageCalculation();
            nextScene = SceneConstants.Credits;
            PlayerPrefs.SetInt(day, 0);
            GoToNextScene();
        }

        if (currentScene.name == SceneConstants.NewDay)
        {
            Invoke("MoveToHomeAgain", 2);

        }
        else
        {
            if (currentScene.name == SceneConstants.Play)
            {
                PlayerPrefs.SetInt(day, 0);
            }

            GameObject gameObject = GameObject.Find("Squirrel");
            playerScript = gameObject.GetComponent<PlayerScript>();
            playerMovement = gameObject.GetComponent<PlayerMovement>();
            sound = GetComponent<AudioSource>();

            if (PlayerPrefs.GetInt("fromVillage") == 0)
            {
                gameObject.transform.position = new Vector3(6, -3.2f, 0);
                signButton.SetActive(true);
                doorButton.SetActive(false);
            }
        }
    }

    private void MoveToHomeAgain()
    {
        HandleSceneTransition();
    }

    private void PercentageCalculation()
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

    public void HandleSceneTransition(bool fromAnswer = false)
    {
        var village = false;
        if (fromAnswer)
        {
            this.nextScene = SceneConstants.NewDay;
        }
        else
        {
            var currentScene = SceneManager.GetActiveScene();
            switch (currentScene.name)
            {
                case SceneConstants.Home:
                    if (playerScript.isPlayerTouchingDoor)
                    {
                        this.nextScene = SceneConstants.Out;
                    }
                    break;
                case SceneConstants.Out:
                    if (playerScript.isPlayerTouchingDoor)
                    {
                        this.nextScene = SceneConstants.Home;
                    }
                    else if (this.playerScript.isPlayerOnPath)
                    {
                        this.nextScene = SceneConstants.Village;
                    };
                    break;
                case SceneConstants.Village:
                    if (playerScript.isPlayerOnPath)
                    {
                        this.nextScene = SceneConstants.Out;
                        village = true;
                    }
                    break;
                case SceneConstants.Play:
                    this.nextScene = SceneConstants.Home;
                    break;
                case SceneConstants.NewDay:
                    this.nextScene = SceneConstants.Home;
                    break;

            }
        }
        this.GoToNextScene(village);
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void GoToNextScene(bool fromVillage = false)
    {
        var fromVillageInt = fromVillage ? 0 : 1;
        PlayerPrefs.SetInt("fromVillage", fromVillageInt);

        SceneManager.LoadScene(this.nextScene);
    }

    public string QuestionChooser()
    {
        dayCount = PlayerPrefs.GetInt(day, 0);
        var text = String.Empty;

        switch (currentScene.name)
        {
            case SceneConstants.Home:
                if (WinningOption() == EPeople.family)
                {
                    text = dialogs[dayCount].questions.positive.family;
                    sound.PlayOneShot(dubbingQuestionsFam[dayCount]);
                }
                else
                {
                    text = dialogs[dayCount].questions.negative.family;
                    sound.PlayOneShot(dubbingQuestionsNegativeFam[dayCount]);
                }
                break;
            case SceneConstants.Out:
                if (WinningOption() == EPeople.mole)
                {
                    text = dialogs[dayCount].questions.positive.mole;
                    sound.PlayOneShot(dubbingQuestionsMole[dayCount]);
                }
                else
                {
                    text = dialogs[dayCount].questions.negative.mole;
                    sound.PlayOneShot(dubbingQuestionsNegativeMole[dayCount]);
                }
                break;
            case SceneConstants.Village:
                if (WinningOption() == EPeople.friend)
                {
                    text = dialogs[dayCount].questions.positive.friend;
                    sound.PlayOneShot(dubbingQuestionsFriend[dayCount]);
                }
                else
                {
                    text = dialogs[dayCount].questions.negative.friend;
                    sound.PlayOneShot(dubbingQuestionsNegativeFriend[dayCount]);
                }
                break;
        }
        return text;
    }

    public string GetPlayerAnswers(bool isPositive)
    {
        dayCount = PlayerPrefs.GetInt(day, 0);
        var text = string.Empty;

        switch (currentScene.name)
        {
            case SceneConstants.Home:
                text = isPositive ? dialogs[dayCount].playerAnswers.positive.family : dialogs[dayCount].playerAnswers.negative.family;
                break;
            case SceneConstants.Out:
                text = isPositive ? dialogs[dayCount].playerAnswers.positive.mole : dialogs[dayCount].playerAnswers.negative.mole;
                break;
            case SceneConstants.Village:
                text = isPositive ? dialogs[dayCount].playerAnswers.positive.friend : dialogs[dayCount].playerAnswers.negative.friend;
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
        dayCount = PlayerPrefs.GetInt(day, 0);

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
                }
                else
                {
                    text = dialogs[dayCount].npcAnswers.negative.mole;
                }
                break;
        }

        dayCount++;
        PlayerPrefs.SetInt(day, dayCount);
        Debug.Log(dayCount);
        Invoke("MoveToNewDay", 3);
        return text;
    }

    private void MoveToNewDay()
    {
        HandleSceneTransition(true);
    }
}
