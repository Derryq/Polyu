using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordPink : MonoBehaviour
{
    public GameObject pswUI;
    public GameObject painting;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            painting.GetComponent<BoxCollider2D>().enabled = false;
            pswUI.SetActive(true);
        }
    }
}