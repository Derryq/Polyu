using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorRoom2 : MonoBehaviour
{
    public Animator ele;
    public Animator str;
    public Animator water;
    GameObject player;
    public GameObject elevator;
    public bool elevatorIn = false;
    private Rigidbody2D rigidbody2d;
    public GameObject painting;
    float vertical;
    Transform camera;
    public AudioClip OpenDoorSound;
    private AudioSource source;
    RobotMove robotMove;
    public bool waterIn;
    public GameObject stopWall1;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        source = GetComponent<AudioSource>();
        robotMove = player.GetComponent<RobotMove>();
        waterIn = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        waterIn = water.GetBool("IsTrigger");
        if (collision.gameObject.tag == "Player" && camera.position.y != 0 && waterIn)
        {
            stopWall1.SetActive(true);
            robotMove.enabled=false;
            source.PlayOneShot(OpenDoorSound, 0.3F);
            ele.SetBool("IsTrigger", true);
            ele.SetBool("Upward", !ele.GetBool("Upward"));
            str.SetBool("IsTrigger", true);
            str.SetBool("Upward", !str.GetBool("Upward"));
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" && camera.position.y != 0 && waterIn)
        {

            collision.transform.SetParent(elevator.transform);
            painting.GetComponent<BoxCollider2D>().enabled = false;
            elevatorIn = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && camera.position.y != 0 && waterIn)
        {
            stopWall1.SetActive(false);
            robotMove.enabled=true;
            collision.transform.SetParent(elevator.transform.parent.transform);
            painting.GetComponent<BoxCollider2D>().enabled = true;
            ele.SetBool("IsTrigger", false);
            str.SetBool("IsTrigger", false);
            //source.mute = true;
        }
    }
}
