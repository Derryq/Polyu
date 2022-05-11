using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorRoom1 : MonoBehaviour
{
    public Animator ele;
    public Animator str;
    public Animator water;
    public GameObject player;
    public GameObject elevator;
    public bool elevatorIn = false;
    private Rigidbody2D rigidbody2d;
    public GameObject painting;
    float vertical;
    Transform camera;
    public AudioClip OpenDoorSound;
    private AudioSource source;
    RobotMove robotMove;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rigidbody2d = player.GetComponent<Rigidbody2D>();
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        source = GetComponent<AudioSource>();
        robotMove = player.GetComponent<RobotMove>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (water.GetBool("IsTrigger") && collision.gameObject.tag == "Player" && camera.position.y != 0)
        {
            robotMove.enabled=false;
            source.PlayOneShot(OpenDoorSound, 0.3F);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {

        if (water.GetBool("IsTrigger") && collision.gameObject.tag == "Player" && camera.position.y != 0)
        {
            Debug.Log("PlayerEnter");
            collision.transform.SetParent(elevator.transform);
            painting.GetComponent<BoxCollider2D>().enabled = false;

            ele.SetBool("IsTrigger", true);
            str.SetBool("IsTrigger", true);

            elevatorIn = true;
            //rigidbody2d.gravityScale = 2;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (water.GetBool("IsTrigger") && collision.gameObject.tag == "Player" && camera.position.y != 0)
        {
            robotMove.enabled=true;
            painting.GetComponent<BoxCollider2D>().enabled = true;
            source.mute = true;
        }
    }
}
