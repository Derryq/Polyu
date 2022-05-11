using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableGravityTrigger : MonoBehaviour
{
    public bool connected;


    // Start is called before the first frame update
    void Start()
    {
        connected = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tube")
        {

            connected = true;
            Debug.Log("SSSSSCollisionStay");
        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tube")
        {

            connected = false;
            Debug.Log("SSSSCollisionExit");
        }

    }
}
