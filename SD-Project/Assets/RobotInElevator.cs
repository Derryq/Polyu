using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotInElevator : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D rigidbody2D;
    public GameObject painting;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Collide");
        if (collision.gameObject.tag == "Player")
        {
           // Debug.Log("Stop");
            rigidbody2D.gravityScale = 0;
            painting.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
