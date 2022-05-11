using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    bool moveLeft = false;
    bool moveRight = false;
    //public SceneFadeInOut fader;

    // 目前问题：move都是一次性的，moveLeft变为true之后没有设置变为false，需要找一个合适的位置变回true！！！
    // 如果在该函数里改，相机就会一直move
    public void MoveLeft()
    {
        if (!moveLeft)
        {
            transform.position = new Vector3(transform.position.x - 11, transform.position.y, transform.position.z);
            moveLeft = true;
            SceneFadeInOut.sceneEnding = true;
        }

    }

    // 问题同上
    public void MoveRight()
    {
        if (!moveRight)
        {
            transform.position = new Vector3(transform.position.x + 11, transform.position.y, transform.position.z);
            moveRight = true;
            SceneFadeInOut.sceneEnding = true;
        }
    }

}
