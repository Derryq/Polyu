using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDown : MonoBehaviour
{
    public Animation anim;
    public Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        anim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartAnimation()
    {
        //For robot down
        
        //anim.enabled = true;
        anim.enabled = false;
        //anim.Play();
    }
}
