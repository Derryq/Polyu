using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityTriggerClick : MonoBehaviour
{
    public bool isClick;
    public GameObject text;
    public AudioClip OpenDoorSound;
    private AudioSource source;
    public GameObject painting;
    public GameObject painting1;
    public BlueTriggerDown playerCollide;
    public YellowTriggerUp playerCollide2;
    public GreenTriggerDown playerCollide1;
    public EnableGravityTrigger enableGravityTrigger;

    void Start()
    {
        isClick = false;
        source = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (playerCollide != null && playerCollide.collide)
        {
            if(enableGravityTrigger.connected)
            {
                isClick = true;
                Debug.Log("1111click");
                source.PlayOneShot(OpenDoorSound, 0.3F);
                if (painting != null)
                {
                    painting.GetComponent<BoxCollider2D>().enabled = false;
                }
                if (painting1 != null)
                {
                    painting1.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
            else
            {
                //source.PlayOneShot(OpenDoorSound, 0.3F);
                if (painting != null)
                {
                    painting.GetComponent<BoxCollider2D>().enabled = true;
                }

            }
            
        }

        else if (playerCollide1 != null && playerCollide1.collide)
        {
            if(enableGravityTrigger.connected)
            {
                isClick = true;
                Debug.Log("2222click1");
                source.PlayOneShot(OpenDoorSound, 0.3F);
                if (painting != null)
                {
                    painting.GetComponent<BoxCollider2D>().enabled = false;
                }
                if (painting1 != null)
                {
                    painting1.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
            else
            {
                //source.PlayOneShot(OpenDoorSound, 0.3F);
                if (painting != null)
                {
                    painting.GetComponent<BoxCollider2D>().enabled = true;
                }
            }
            
        }

        else if (playerCollide2 != null && playerCollide2.collide)
        {
            if(enableGravityTrigger.connected)
            {
                isClick = true;
                Debug.Log("click2");
                source.PlayOneShot(OpenDoorSound, 0.3F);
                if (painting != null)
                {
                    painting.GetComponent<BoxCollider2D>().enabled = false;
                }
                if (painting1 != null)
                {
                    painting1.GetComponent<BoxCollider2D>().enabled = false;
                }
            }         
            else
            {
                Debug.Log("click2");
                //source.PlayOneShot(OpenDoorSound, 0.3F);
                if (painting != null)
                {
                    painting.GetComponent<BoxCollider2D>().enabled = true;
                }
            }
        }

    }
}
