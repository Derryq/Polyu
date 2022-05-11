using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController1 : MonoBehaviour
{
    public float speed = 3.0f;
    public float timeInvincible = 2.0f;

    Rigidbody2D rigidbody2d;
    Animator animator;
    float horizontal;
    float vertical;
    Vector2 lookDirection = new Vector2(1, 0);

    public CameraFollow camera; // Change the position of camera

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        Vector2 move = new Vector2(horizontal, 0);

        if (!Mathf.Approximately(move.x, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }

        animator.SetFloat("Look X", lookDirection.x);
        animator.SetFloat("Speed", move.magnitude);

        // Change the position of camera
        // 有两个，因为还不确定哪一种更好，都还有问题
        DetectEntrySeperate(); //用于EntryLeft, EntryRight同时存在的情况
        //DetectEntry(); //用于只存在Entry的情况
    }


    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        

        rigidbody2d.MovePosition(position);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
     
        if(other.gameObject.tag == "Elevator")
        {
            
            Debug.Log("In elevator");
            Vector2 end = rigidbody2d.position;
            end.y = end.y - 100f;
            MoveDown(end);
        }
       
    }

    IEnumerator MoveDown(Vector2 target)
    {
        
        transform.position = Vector2.MoveTowards(transform.position, target, 1f * Time.deltaTime);
        Debug.Log("Move");
        yield return 0;
    }

    // 有EntryLeft, EntryRight
    void DetectEntrySeperate()
    {
        // RayCast detect whether there is an "EntryLeft"
        if (Physics2D.Raycast(this.transform.position, Vector2.left, 1.0f, 1 << LayerMask.NameToLayer("EntryLeft")))
        {
            string colliderName = Physics2D.Raycast(this.transform.position, Vector2.left, 1.0f,
                1 << LayerMask.NameToLayer("EntryLeft")).collider.gameObject.name;
            // Display collider name
            Debug.Log("EntryLeft " + colliderName + " is on the left");

            // Move camera to left
            camera.MoveLeft();
            Debug.DrawRay(this.transform.position, Vector2.left, Color.green);
        }

        // RayCast detect whether there is an "EntryRight"
        else if (Physics2D.Raycast(this.transform.position, Vector2.right, 1.0f, 1 << LayerMask.NameToLayer("EntryRight")))
        {
            string colliderName = Physics2D.Raycast(this.transform.position, Vector2.right, 1.0f,
                1 << LayerMask.NameToLayer("EntryRight")).collider.gameObject.name;
            Debug.Log("EntryRight " + colliderName + " is on the right");
            camera.MoveRight();
            Debug.DrawRay(this.transform.position, Vector2.right, Color.green);
        }

        else
        {
            Debug.Log("No collider");
            //Debug.DrawRay(this.transform.position, Vector2.left, Color.green);
        }
    }

    //只有Entry
    void DetectEntry()
    {
        if (Physics2D.Raycast(this.transform.position, Vector2.left, 1.0f, 1 << LayerMask.NameToLayer("Entry")))
        {
            string colliderName = Physics2D.Raycast(this.transform.position, Vector2.left, 1.0f,
                1 << LayerMask.NameToLayer("Entry")).collider.gameObject.name;
            Debug.Log("Entry " + colliderName + " is on the left");
            camera.MoveLeft();
            Debug.DrawRay(this.transform.position, Vector2.left, Color.green);
        }

        else if (Physics2D.Raycast(this.transform.position, Vector2.right, 1.0f, 1 << LayerMask.NameToLayer("Entry")))
        {
            string colliderName = Physics2D.Raycast(this.transform.position, Vector2.right, 1.0f,
                1 << LayerMask.NameToLayer("Entry")).collider.gameObject.name;
            Debug.Log("Entry " + colliderName + " is on the right");
            camera.MoveRight();
            Debug.DrawRay(this.transform.position, Vector2.right, Color.green);
        }

        else
        {
            Debug.Log("No collider");
            //Debug.DrawRay(this.transform.position, Vector2.left, Color.green);
        }
    }
}
