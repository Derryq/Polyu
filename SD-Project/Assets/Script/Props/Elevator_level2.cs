using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_level2 : MonoBehaviour
{
    public Animator ani;
    public Animator ani1;
    public GameObject player;
    public GameObject elevator;
    public bool elevatorIn = false;
    private Rigidbody2D rigidbody2d;
    public GameObject painting;
    float vertical;
    Transform camera;
    public AudioClip OpenDoorSound;
    private AudioSource source;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = player.GetComponent<Rigidbody2D>();
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" && camera.position.y != 0)
        {
            Debug.Log("PlayerEnter");
            source.PlayOneShot(OpenDoorSound, 0.3F);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player" && camera.position.y != 0)
        {
            Debug.Log("PlayerEnter");
            collision.transform.SetParent(elevator.transform);
            painting.GetComponent<BoxCollider2D>().enabled = false;
            
            ani.SetBool("ElevatorUp", true);
            ani1.SetBool("StringUp", true);
            
            elevatorIn = true;
            //rigidbody2d.gravityScale = 2;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && camera.position.y != 0)
        {
            painting.GetComponent<BoxCollider2D>().enabled = true;
            source.mute = true;
        }
    }

}
