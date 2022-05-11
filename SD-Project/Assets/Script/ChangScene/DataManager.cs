using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int param = GameObject.Find("GameData").GetComponent<GameData>().param;
        Debug.Log(param);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
