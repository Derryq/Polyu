using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeConnected : MonoBehaviour
{
    public bool connected;
    // Start is called before the first frame update
    void Start()
    {
        
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
            Debug.Log("1111CollisionStay");
        }
        
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tube")
        {

            connected = false;
            Debug.Log("1111CollisionExit");
        }

    }

}
