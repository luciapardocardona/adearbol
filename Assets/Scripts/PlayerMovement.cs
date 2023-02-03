using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float runSpeed = 8f;
    [SerializeField] float jumpSpeed = 15f;
    [SerializeField] List<GameObject> monsters;
    GameManager gameManager;
    NPCsMovement nPCsMovement;
    PlayerScript playerScript;
    Vector2 moveInput;
    Rigidbody2D myRigidbody;
    Animator myAnimator;
    AudioSource sound;
    BoxCollider2D myBoxCollider;
    SpriteRenderer sprite;
    private bool thereIsSwitch;
    private string scene;
    public AudioClip soundJump;

    void Awake()
    {
        //gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponentInChildren<Animator>();
        sound = GetComponent<AudioSource>();
        myBoxCollider = GetComponent<BoxCollider2D>();
        playerScript = GetComponent<PlayerScript>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        nPCsMovement = GetComponent<NPCsMovement>();

        scene = SceneManager.GetActiveScene().name;        
    }

    public void Run()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon;
        Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVelocity;
        //myAnimator.SetBool(AnimationConstants.Walk, playerHasHorizontalSpeed);


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
    void OnJump(InputValue value)
    {
        //LayerMask groundLayer = LayerMask.GetMask(LayerConstants.Ground);
        //if (value.isPressed && myBoxCollider.IsTouchingLayers(groundLayer))
        //{
        //    myRigidbody.velocity += new Vector2(0f, jumpSpeed);
        //    sound.PlayOneShot(soundJump);
        //    //myAnimator.SetTrigger(AnimationConstants.hasJump);
        //}
    }
    void OnAction(InputValue value)
    {
        //if (playerScript.isPlayerTouchingDoor)
        //{
        //    gameManager.HandleSceneTransition();
        //}
        //else if (playerScript.isPlayerOnSwitch)
        //{
        //    if (scene == SceneConstants.Nivel3)
        //    {
        //        switchScript.isLightOn = !switchScript.isLightOn;
        //        nPCsMovement.MoveMonsters();
        //    }
        //    else
        //    {
        //        switchScript.isLightOn = true;
        //    }
        //    switchScript.ToggleLight();
        //    TogglePlayerColor();

        //}
    }
    void OnEscape(InputValue value)
    {
       // SceneManager.LoadScene(SceneConstants.Menu);
    }

    private void TogglePlayerColor()
    {
        //if (thereIsSwitch)
        //{
        //    myAnimator.SetBool("isB&W", !switchScript.isLightOn);
        //    foreach (var item in monsters)
        //    {
        //        var monster = item.GetComponentInChildren<Animator>();
        //        monster.SetBool("isB&W", !switchScript.isLightOn);
        //    }
        //}
        //else
        //{
        //    myAnimator.SetBool("isB&W", false);
        //    foreach (var item in monsters)
        //    {
        //        var monster = item.GetComponentInChildren<Animator>();
        //        monster.SetBool("isB&W", false);
        //    }
        //}
    }
}
