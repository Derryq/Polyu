using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableSubmarine : MonoBehaviour
{
    public bool connected;
    //public bool waterIn;
    //public Animator water;
    public FlowButton FlowButton;
    public GameObject elevatorTrigger;

    // Start is called before the first frame update
    void Start()
    {
        connected = false;
        //waterIn = false;
    }

    // Update is called once per frame
    void Update()
    {
        SubmarineOn();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tube")
        {
            //waterIn = water.GetBool("IsTrigger");
            connected = FlowButton.flowOut;
            Debug.Log("CollisionStay");
        }

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tube")
        {

            connected = FlowButton.flowOut;
            Debug.Log("CollisionStay");
        }

    }

    private void SubmarineOn()
    {
        if(connected)
        {
            elevatorTrigger.SetActive(true);
        }
    }
}
