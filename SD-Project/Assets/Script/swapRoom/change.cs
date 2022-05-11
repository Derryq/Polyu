using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class change : MonoBehaviour
{
    //单例模式
    static private change instance;
    //储存鼠标点击时触碰到的对象和鼠标按下状态时触碰到的对象
    thing pressthing;
    thing enterthing;
    Transform camera;
   
    public static change Instance { get => instance; set => instance = value; }

    private void Awake()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        instance = this;
    }


    //当鼠标按下时，得到鼠标所对应的物体
    public void MouseDown(thing press)
    {
        pressthing = press;
    }


    //当鼠标在按下的状态时，得到此时鼠标所对应的物体
    public void MouseEnter(thing enter)
    {
        enterthing = enter;
    }

    //当鼠标释放时时，交换两者的位置
    public void MouseUp()
    {
        if (EventSystem.current.IsPointerOverGameObject()) return;
        if(thing.roomChanging) return;
        if (camera.position.y == 0)
        {
            StartCoroutine(pressthing.Move(enterthing, 1));
            StartCoroutine(enterthing.Move(pressthing, 1));
        }
    }
}
