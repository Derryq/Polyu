using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPuzzle : MonoBehaviour
{
    public GameObject clueSheet;
    public GameObject close;
    public Animator clue;
    public bool IsClick = false;
    bool playerEnter = false;
    public GameObject clueButton;
     private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        if(playerEnter)
        {
            IsClick = true;
            source.Play();
        } 
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerEnter = true;
            if (IsClick)
            {
                if (clueSheet != null)
                {
                    close.SetActive(true);
                    clueSheet.SetActive(true);
                    clueButton.SetActive(true);
                    if (clueButton != null)
                    {
                        clueButton.SetActive(true);
                        clue.SetBool("IsTrigger", true);
                    }
                }
            }
           
        }
    }
     void OnCollisionExit2D(Collision2D other)
    {  
        if (other.gameObject.tag == "Player")
        {
            playerEnter=false;
            //clueButton.SetActive(false);
        }
    }
}
