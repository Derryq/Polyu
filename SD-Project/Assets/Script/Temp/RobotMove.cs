using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMove : MonoBehaviour
{
    public float speed = 3.0f;
    public float timeInvincible = 2.0f;

    Rigidbody2D rigidbody2d;
    Animator animator;
    float horizontal;
    float vertical;
    Vector2 lookDirection = new Vector2(1, 0);

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


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
    }


    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;


        rigidbody2d.MovePosition(position);
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Elevator")
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

}
