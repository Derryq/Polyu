using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowSwitch : MonoBehaviour
{
    public bool isClick;
    public GameObject text;
    public AudioClip OpenDoorSound;
    private AudioSource source;
    public FlowButton playerCollide;
    public TubeConnected tubeConnected;

    void Start()
    {
        isClick = false;
        source = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        Debug.Log("click");
        if (playerCollide != null && playerCollide.collide && tubeConnected.connected)
        {
            isClick = true;
            //Debug.Log("click");
            source.PlayOneShot(OpenDoorSound, 0.3F);
            //if (painting != null)
            //{
            //painting.GetComponent<BoxCollider2D>().enabled = false;
            //}
        }

    }
}
