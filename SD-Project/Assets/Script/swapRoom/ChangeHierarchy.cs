using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHierarchy : MonoBehaviour
{
    RobotMove robotMove;
    Transform camera;
    thing thing;
    GameObject robot;
    GameObject[] wall;
    GameObject[] elevator;
    BoxCollider2D col;
    GameObject[] tube;

    bool roomChanging;

    void Start()
    {
        robot = GameObject.FindGameObjectWithTag("Player");
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        wall = GameObject.FindGameObjectsWithTag("Wall");
        robotMove = robot.GetComponent<RobotMove>();
        thing = this.GetComponent<thing>();
        elevator = GameObject.FindGameObjectsWithTag("ElevatorWall");
        tube = GameObject.FindGameObjectsWithTag("Tube");
    }

    void Update()
    {
        roomChanging = thing.roomChanging;
        if (camera.position.y==0)
        {
            SetWallTrigger(true);
            SetElevatorTrigger(true);
            SetTube(true);
            if (!roomChanging)
            { 
                robotMove.enabled=false;  
            }

        }
        else
        {
            robotMove.enabled=true;
            SetWallTrigger(false);
            SetElevatorTrigger(true);
            SetTube(true);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
           if(camera.position.y!=0)
           {
               other.transform.SetParent(this.transform);
           }            
        }          
    }

    private void SetWallTrigger(bool a)
    {
        foreach(GameObject w in wall)
        {
            col = w.GetComponent<BoxCollider2D>();
            col.isTrigger=a;
        }
    }

    private void SetElevatorTrigger(bool a)
    {
        foreach(GameObject e in elevator)
        {
            col = e.GetComponent<BoxCollider2D>();
            col.isTrigger = a;
        }
    }

    private void SetTube(bool a)
    {
        foreach (GameObject e in tube)
        {
            col = e.GetComponent<BoxCollider2D>();
            col.isTrigger = a;
        }
    }
}
