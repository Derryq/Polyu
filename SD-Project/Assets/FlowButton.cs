using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowButton : MonoBehaviour
{
    public Animator ani;
    public Animator ani1;
    public Animator ani2;
    public Animator ani3;
    public GameObject player;
    public bool IsTrigger = false;
    private float speed = 1f;
    private Vector3 endPosition = new Vector3();
    private Rigidbody2D rigidbody2d;
    private Vector3 dir;
    private bool mouseDown;
    public FlowSwitch appleSwitch;
    public GameObject text;
    public bool collide;
    public TubeConnected tubeConnected;
    public bool flowOut;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rigidbody2d = player.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //collide = false;
        //connected = tubeConnected.connected;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {

        }
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            collide = true;
            Debug.Log("CollisionStay");
            if (text != null)
            {
                text.SetActive(true);
            }
            /*if (appleSwitch.isClick)
            {
                if(tubeConnected.connected == true)
                {
                    Debug.Log("click");
                    ani.SetBool("IsTrigger", true);
                    ani1.SetBool("IsTrigger", true);
                    ani2.SetBool("IsTrigger", true);
                    ani3.SetBool("IsTrigger", true);
                    endPosition = new Vector3(player.transform.position.x, player.transform.position.y - 7f, player.transform.position.z);
                    Debug.Log("Play Animation");
                    appleSwitch.isClick = false;
                    flowOut = true;
                }
                
            }*/
            if (tubeConnected.connected == true)
            {
                if (appleSwitch.isClick)
                {
                    ani.SetBool("IsTrigger", true);
                    ani1.SetBool("IsTrigger", true);
                    ani2.SetBool("IsTrigger", true);
                    ani3.SetBool("IsTrigger", true);
                    endPosition = new Vector3(player.transform.position.x, player.transform.position.y - 7f, player.transform.position.z);
                    Debug.Log("Play Animation");
                    appleSwitch.isClick = false;
                    flowOut = true;
                }
            }
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            collide = false;
        }
    }
}

