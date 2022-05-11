using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToPhone : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("Click to return");
        GameObject.Find("GameDataLevel1").GetComponent<GameDataLevel1>().param = 321321321;
        SceneManager.LoadScene("level1");
    }
}
