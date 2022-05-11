using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindClue : MonoBehaviour
{
    private Animator anim;
    public Animator clue;
    public bool IsClick = false;
    bool playerEnter = false;
    public GameObject clueSheet;
    public GameObject close;
    int clickCount=0;
    private AudioSource source;
    public GameObject clueButton;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }
    void OnMouseDown()
    { 
        if (playerEnter)
        {   
            source.Play();
            IsClick = true;
            clickCount+=1;
        } 
    }
 
    void OnCollisionStay2D(Collision2D other)
    {  
        if (other.gameObject.tag == "Player")
        {
            playerEnter=true;
            if (IsClick)
            {
               anim.SetBool("FindClue", true);
                if (clickCount>1)
                {
                  if(clueButton!=null && clue != null)
                  {
                      clueButton.SetActive(true);
                      clue.SetBool("IsTrigger", true);
                  }
                    clueSheet.SetActive(true);
                    close.SetActive(true);
                }
            }
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {  
        if (other.gameObject.tag == "Player")
        {
            playerEnter=false;
            if(clueButton!=null && clue!=null)
                  {
                     //clueButton.SetActive(false);
                //clue.SetBool("IsTrigger", false);
                  }
        }
    }
}
