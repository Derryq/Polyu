using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraZoomIn : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject player;
    public Vector3 originallocation;
    public SceneFader fader;
    public Image buttonimg;
    public Button changeButton;
    Vector3 location;
    GameObject parent_room;
    GameObject parent_room2;
    GameObject[] roomList;
    Renderer renderer;
    Scene scene;
    bool roomChanging;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
        player = GameObject.FindGameObjectWithTag("Player");
        originallocation = new Vector3(0, 0, -10f);
        roomList=GameObject.FindGameObjectsWithTag("Room");
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    public void OnClick()
    {
        parent_room = player.transform.parent.gameObject;
        //originallocation = mainCamera.transform.position;
        location = parent_room.transform.position;
        mainCamera.transform.position = new Vector3(location.x, location.y, originallocation.z);
        mainCamera.orthographicSize = 2f;
        SceneFader.sceneEnding = true;
        //buttonimg.gameObject.SetActive(false);
        //buttonimg.GetComponent<Renderer>().enabled = false;
        buttonimg.GetComponent<CanvasGroup>().alpha = 0;
    }

    void Update()
    {
        foreach (GameObject room in roomList)
        {
            thing t = room.GetComponent<thing>();
            roomChanging = thing.roomChanging;
            if (roomChanging)
            {
                changeButton.interactable = false;
            }
            else
            {
                changeButton.interactable = true;
            }
        }
        parent_room = player.transform.parent.gameObject;
        if(mainCamera.transform.position.y!=0 && parent_room.tag=="Room")
        {
            SetRoomVisible(parent_room);
            if (parent_room!=parent_room2)
            {
                SetRoomVisible(parent_room);
                //originallocation = mainCamera.transform.position;
                location = parent_room.transform.position;
                mainCamera.transform.position = new Vector3(location.x, location.y, originallocation.z);
            }            
        }
        parent_room2 = player.transform.parent.gameObject;
    }

    void SetRoomVisible(GameObject parent_room)
    {
        foreach(GameObject room in roomList)
            {
                if(room!=parent_room)
                {
                room.GetComponent<Renderer>().enabled = false;
                Transform[] allTrans = room.GetComponentsInChildren<Transform>(true);
                   for (int i = 0; i < allTrans.Length; i++)
                  {
                    renderer = allTrans[i].gameObject.GetComponent<Renderer>();
                    if (renderer != null)
                    {
                        renderer.enabled = false;
                    }
                  }
                }
                else{
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
}
