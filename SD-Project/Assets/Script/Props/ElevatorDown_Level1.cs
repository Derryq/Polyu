using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ElevatorDown_Level1 : MonoBehaviour
{
    public Animator ani;
    public Animator ani1;
    private KeyCode key;
    GameObject player;
    public GameObject elevator;
    public bool elevatorIn = false;
    private float speed = 1f;
    private Vector3 endPosition = new Vector3();
    private Rigidbody2D rigidbody2d;
    private Vector3 dir;
    Transform camera;
    public GameObject painting;
    RobotMove robotMove;
    public AudioClip OpenDoorSound;
    private AudioSource source;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rigidbody2d = player.GetComponent<Rigidbody2D>();
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        source = GetComponent<AudioSource>();
        robotMove = player.GetComponent<RobotMove>();
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && camera.position.y != 0)
        {
            robotMove.enabled=false;
            source.PlayOneShot(OpenDoorSound, 0.3F);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && camera.position.y != 0)
        {
            other.transform.SetParent(elevator.transform);
            painting.GetComponent<BoxCollider2D>().enabled = false;
            ani.SetBool("PlayerIn", true);
            ani1.SetBool("PlayerIn", true);
            endPosition = new Vector3(player.transform.position.x, player.transform.position.y-7f, player.transform.position.z);
            elevatorIn = true;
            //source.PlayOneShot(OpenDoorSound, 0.5F);

        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && camera.position.y != 0)
        {
            robotMove.enabled=true;
            painting.GetComponent<BoxCollider2D>().enabled = true;
            source.mute = true;
        }
    }





}
