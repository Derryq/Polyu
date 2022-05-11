using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_level2_2 : MonoBehaviour
{
    public Animator ani;
    public Animator ani1;
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

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rigidbody2d = player.GetComponent<Rigidbody2D>();
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        source = GetComponent<AudioSource>();
        robotMove = player.GetComponent<RobotMove>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" && camera.position.y != 0)
        {
            robotMove.enabled=false;
            source.PlayOneShot(OpenDoorSound, 0.3F);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && camera.position.y != 0)
        {
            collision.transform.SetParent(elevator.transform);
            painting.GetComponent<BoxCollider2D>().enabled = false;


            ani.SetBool("ElevatorDown", true);
            ani1.SetBool("StringDown", true);

            elevatorIn = true;
            //rigidbody2d.gravityScale = 2;
            
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
