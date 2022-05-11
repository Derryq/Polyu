using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAni : MonoBehaviour
{
    GameObject player;
    private Rigidbody2D rigidbody2D;
    public Animator ani;
    public GameObject painting;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        rigidbody2D = player.GetComponent<Rigidbody2D>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Collide");
        if (collision.gameObject.tag == "Player")
        {
            // Debug.Log("Stop");
            rigidbody2D.gravityScale = 0;
            ani.SetBool("IsTrigger", false);
            if(painting)
            {
                painting.GetComponent<BoxCollider2D>().enabled = true;
            }
            
        }
    }
}
