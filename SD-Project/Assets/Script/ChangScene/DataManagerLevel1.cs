using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManagerLevel1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int param = GameObject.Find("GameDataLevel1").GetComponent<GameDataLevel1>().param;
        Debug.Log(param);
    }

    // Update is called once per frame
    void Update()
    {

    }
}