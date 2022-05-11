using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PaintingReturn : MonoBehaviour
{
    public Camera mainCamera;
    public Image buttonimg;
    GameObject[] roomList;
    Renderer renderer;
    Scene scene;
    private AudioSource source;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        roomList =GameObject.FindGameObjectsWithTag("Room");
        source = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if(mainCamera.transform.position.y != 0)
        {
            source.Play();
        }     
        Vector3 cameralocation = new Vector3(0, 0, -10f);
        mainCamera.transform.position = cameralocation;
        if (scene.name == "level2_1"||scene.name == "level2_2")
        {
            mainCamera.orthographicSize = 4.2f;
        }
        else if (scene.name == "level5")
        {
            mainCamera.orthographicSize = 4f;
        }
        else
        {
            mainCamera.orthographicSize = 5f;
        }
        buttonimg.GetComponent<CanvasGroup>().alpha = 1;
        SceneFader.sceneEnding = true;
        foreach (GameObject room in roomList)
            {
                room.GetComponent<Renderer>().enabled = true;
            Transform[] allTrans = room.GetComponentsInChildren<Transform>(true);
            for (int i = 0; i < allTrans.Length; i++)
            {
                renderer = allTrans[i].gameObject.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = true;
                }
            }
        }
    }
}
