using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public int jump = 10, vel = 8;
    Rigidbody2D myRigidbody;
    float enX;
    public SpriteRenderer sprite;
    public Animator animacion;
    public AudioClip soundsalto;
    AudioSource sonido;
    GameObject padre;
    CapsuleCollider2D capsule;

    PlayerMovement movement;
    public bool isPlayerTouchingDoor;
    public bool isPlayerOnExit;
    public bool isPlayerOnSwitch;

    void Awake()
    {
        movement = GetComponent<PlayerMovement>();
        sonido = GetComponent<AudioSource>();
        capsule = GetComponent<CapsuleCollider2D>();
        myRigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movement.Run();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //// Si entra en una puerta
        //isPlayerTouchingDoor = other.gameObject.CompareTag(TagConstants.Door);

        //if (isPlayerTouchingDoor)
        //{
        //    isPlayerOnExit = other.gameObject.GetComponent<DoorScript>().isCorrectDoor;
        //}
        //else
        //{
        //    isPlayerOnSwitch = other.gameObject.CompareTag(TagConstants.Switch);
        //}
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //switch (other.gameObject.tag)
        //{
        //    case TagConstants.Door:
        //        isPlayerTouchingDoor = false;
        //        isPlayerOnExit = false;
        //        break;
        //    case TagConstants.Switch:
        //        isPlayerOnSwitch = false;
        //        break;
        //    default:
        //        break;
        //}
    }
}
