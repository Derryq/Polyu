using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    public GameObject hint;
    public GameObject arrow;
    Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (camera.position.y == 0)
        { 
            hint.SetActive(false);
            arrow.SetActive(true);
        }
        else
        {
            hint.SetActive(true);
            arrow.SetActive(false);
        }

    }
}
