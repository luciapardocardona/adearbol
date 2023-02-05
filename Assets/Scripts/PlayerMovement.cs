using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float runSpeed = 5f;
    [SerializeField] TextMeshProUGUI dialogText;
    [SerializeField] GameObject dialogButton;
    [SerializeField] TextMeshProUGUI buttonText;
    [SerializeField] int charPerDialog = 50;
    int dialogSection = 0;
    GameManager gameManager;
    PlayerScript playerScript;
    Vector2 moveInput;
    public Rigidbody2D myRigidbody;
    Animator myAnimator;
    AudioSource sound;
    BoxCollider2D myBoxCollider;
    SpriteRenderer sprite;
    private string scene;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponentInChildren<Animator>();
        sound = GetComponent<AudioSource>();
        myBoxCollider = GetComponent<BoxCollider2D>();
        playerScript = GetComponent<PlayerScript>();
        sprite = GetComponentInChildren<SpriteRenderer>();

        scene = SceneManager.GetActiveScene().name;
    }

    public void Run()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon;
        Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVelocity;
        myAnimator.SetBool("isWalking", playerHasHorizontalSpeed);

        if (myRigidbody.velocity.x > 0)
        {
            sprite.flipX = false;
        }
        else if (myRigidbody.velocity.x < 0)
        {
            sprite.flipX = true;
        }
    }
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void OnAnyButton()
    {
        this.gameManager.HandleSceneTransition();
    }

    void OnAction(InputValue value)
    {
        if (playerScript.isPlayerTouchingDoor || playerScript.isPlayerOnPath)
        {
            this.gameManager.HandleSceneTransition();
        }
        else if (playerScript.isPlayerOnNpc)
        {
            InsertText(gameManager.QuestionChooser());
        }
    }

    private void InsertText(string text)
    {

        var totalSections = Mathf.Ceil(text.Length / charPerDialog);

        if (totalSections >= dialogSection)
        {
            dialogText.gameObject.SetActive(true);
            dialogButton.SetActive(false);
            buttonText.enabled = false;

            runSpeed = 0f;

            // var totalCharToShow = (dialogSection + 1) * charPerDialog > text.Length ? text.Length - (dialogSection * charPerDialog) : charPerDialog;

            dialogText.text = text;
            // .Substring(dialogSection * charPerDialog, totalCharToShow);
            dialogSection++;
        }
    }

    void OnCancel()
    {
        runSpeed = 5f;
        dialogText.gameObject.SetActive(false);
        dialogButton.SetActive(true);
        buttonText.enabled = true;
    }

    void OnDecline()
    {
        InsertText(gameManager.AnswerChooser(false));
    }

    void OnAccept()
    {
        InsertText(gameManager.AnswerChooser(true));
    }

    void OnEscape(InputValue value)
    {
        // SceneManager.LoadScene(SceneConstants.Menu);
    }

}
