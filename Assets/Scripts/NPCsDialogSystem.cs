using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPCsDialogSystem : MonoBehaviour
{
    [SerializeField] GameObject dialogButton;

    [SerializeField] List<string> dialogs;

    //[SerializeField] AudioClip soundnpc;

    //AudioSource sound;
    public int selectedText = 0;

    // Start is called before the first frame update
    void Start()
    {
        dialogButton.SetActive(false);
        //sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //sound.PlayOneShot(soundnpc);
        dialogButton.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        dialogButton.SetActive(false);
    }
}
