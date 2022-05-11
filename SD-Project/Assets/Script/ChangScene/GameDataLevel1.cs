using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataLevel1 : MonoBehaviour
{
    public int param;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}
