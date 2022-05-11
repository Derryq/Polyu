using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTriggerDownClick : MonoBehaviour
{
    public bool isClick;
    public GameObject text;
    public AudioClip OpenDoorSound;
    private AudioSource source;
    public GameObject painting;
    public YellowTriggerDown playerCollide;
    public YellowTriggerUp playerCollide1;
    public PinkTriggerDown playerCollide2;

    void Start()
    {
        isClick = false;
        source = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (playerCollide != null && playerCollide.collide)
        {
            isClick = true;
            Debug.Log("click");
            source.PlayOneShot(OpenDoorSound, 0.3F);
            if (painting != null)
            {
                painting.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

        else if (playerCollide1 != null && playerCollide1.collide)
        {
            isClick = true;
            Debug.Log("click1");
            source.PlayOneShot(OpenDoorSound, 0.3F);
            if (painting != null)
            {
                painting.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

        else if (playerCollide2 != null && playerCollide2.collide && playerCollide2.pswRight)
        {
            isClick = true;
            Debug.Log("click2");
            source.PlayOneShot(OpenDoorSound, 0.3F);
            if (painting != null)
            {
                painting.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

    }
}
