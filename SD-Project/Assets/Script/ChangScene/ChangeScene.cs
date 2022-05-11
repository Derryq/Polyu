using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        GameObject.Find("GameData").GetComponent<GameData>().param = 12313213;
        SceneManager.LoadScene("level1_Room");//level1为我们要切换到的场景
    }

    // Update is called once per frame
    void Update () {

    }
}
