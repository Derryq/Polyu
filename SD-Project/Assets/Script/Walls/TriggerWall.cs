using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWall : MonoBehaviour
{
    BoxCollider2D col;
    Transform camera;
    bool collide=false;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        col = this.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (camera.position.y == 0 || collide)
        {
            col.isTrigger = true;
        }
        if(camera.position.y != 0 && !collide)
        {
            col.isTrigger = false;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {     
        if (other.gameObject.CompareTag("TriggerWall"))
        {
            collide = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("TriggerWall"))
        {
            collide = false;
        }
    }
}
