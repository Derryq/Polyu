using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePuzzle : MonoBehaviour
{
    public GameObject clueSheet;
    public ShowPuzzle p;
    public Animator clue;
    public GameObject close;
    public GameObject closeAudio;
    AudioSource source;
    public GameObject clueButton;
    //public bool IsClick = false;
    void Start()
    {
        source = closeAudio.GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        source.Play();
        p.IsClick = false;
        //clueSheet.SetActive(false);
        if (clueSheet != null)
        {
            close.SetActive(false);
            clueSheet.SetActive(false);
            if (clue != null)
            {
                clue.SetBool("IsTrigger", false);
                clueButton.SetActive(false);
            }
        }
    }
}
