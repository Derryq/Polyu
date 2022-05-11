using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterSwitch: MonoBehaviour
{
    public bool isClick;
    public GameObject text;
    public AudioClip OpenDoorSound;
    private AudioSource source;
    public waterButton playerCollide;

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
            //if (painting != null)
            //{
                //painting.GetComponent<BoxCollider2D>().enabled = false;
            //}
        }

    }
}