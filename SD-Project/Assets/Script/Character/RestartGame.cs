using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public GameObject player;
    private Vector3 location;
    Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        location = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (scene.name == "level2_2" || scene.name == "level2_1")
        {
            location = player.transform.position;
            if (location.y > 1.6)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
