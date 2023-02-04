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
    public bool isPlayerOnPath;

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
        isPlayerTouchingDoor = other.gameObject.CompareTag(TagConstants.Door);

        isPlayerOnPath = other.gameObject.CompareTag(TagConstants.Path);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        switch (other.gameObject.tag)
        {
            case TagConstants.Door:
                isPlayerTouchingDoor = false;
                break;
            case TagConstants.Path:
                isPlayerOnPath = false;
                break;
            default:
                break;
        }
    }
}
