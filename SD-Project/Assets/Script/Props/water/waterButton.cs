using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class waterButton : MonoBehaviour
{
    public Animator ani;
    public Animator ani1;
    public Animator ani2;
    public GameObject player;
    public bool IsTrigger = false;
    private float speed = 1f;
    private Vector3 endPosition = new Vector3();
    private Rigidbody2D rigidbody2d;
    private Vector3 dir;
    private bool mouseDown;
    public waterSwitch appleSwitch;
    public GameObject text;
    public bool collide;


    void Awake()
    {
        rigidbody2d = player.GetComponent<Rigidbody2D>();
        collide = false;
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
            if (appleSwitch.isClick)
            {
                Debug.Log("click");
                ani.SetBool("IsTrigger", true);
                ani1.SetBool("IsTrigger", true);
                ani2.SetBool("IsTrigger", true);
                endPosition = new Vector3(player.transform.position.x, player.transform.position.y - 7f, player.transform.position.z);
                Debug.Log("Play Animation");
                appleSwitch.isClick = false;
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

