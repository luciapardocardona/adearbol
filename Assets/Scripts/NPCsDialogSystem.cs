using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPCsDialogSystem : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI dialog;

    [SerializeField]
    List<string> dialogs;

    //[SerializeField] AudioClip soundnpc;

    //AudioSource sound;
    public int selectedText = 0;

    // Start is called before the first frame update
    void Start()
    {
        dialog.enabled = false;
        //sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        dialog.text = this.dialogs[selectedText];
        //sound.PlayOneShot(soundnpc);
        dialog.enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        dialog.text = string.Empty;
        dialog.enabled = false;
    }
}
