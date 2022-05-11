using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkTriggerDown : MonoBehaviour
{

    public Animator ani;
    public GameObject player;
    public bool IsTrigger = false;
    private float speed = 1f;
    private Vector3 endPosition = new Vector3();
    private Rigidbody2D rigidbody2d;
    private Vector3 dir;
    private bool mouseDown;
    public YellowTriggerDownClick appleSwitch;
    public GameObject text;
    public SaveName psw;
    public GameObject painting;
    public bool collide;
    public bool pswRight;


    void Awake()
    {
        rigidbody2d = player.GetComponent<Rigidbody2D>();
        collide = false;
        pswRight = false;
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("CollisionEnter");
        }
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            collide = true;
            Debug.Log("CollisionStay");
            if (psw.IsRight)
            {
                pswRight = true;
                //source.PlayOneShot(OpenDoorSound, 0.3F);
                if (text != null)
                {
                    //bool isActive = text.activeSelf;
                    text.SetActive(true);
                }
                if (appleSwitch.isClick)
                {
                    Debug.Log("click");
                    ani.SetBool("IsTrigger", true);
                    //ani1.SetBool("PlayerIn", true);
                    endPosition = new Vector3(player.transform.position.x, player.transform.position.y - 7f, player.transform.position.z);
                    Debug.Log("Play Animation");
                    appleSwitch.isClick = false;
                    rigidbody2d.gravityScale = -2;
                    if (painting!=null)
                        painting.GetComponent<BoxCollider2D>().enabled = false;

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
