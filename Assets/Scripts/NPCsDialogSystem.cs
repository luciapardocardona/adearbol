using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPCsDialogSystem : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI dialogButton;

    [SerializeField]
    List<string> dialogs;

    bool isPlayerOnCharacter;

    //[SerializeField] AudioClip soundnpc;

    //AudioSource sound;
    public int selectedText = 0;

    // Start is called before the first frame update
    void Start()
    {
        dialogButton.enabled = false;
        isPlayerOnCharacter = false;
        //sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        // Show button to press
        dialogButton.text = "Press button";
        //sound.PlayOneShot(soundnpc);
        dialogButton.enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        dialogButton.text = string.Empty;
        dialogButton.enabled = false;
    }
}
