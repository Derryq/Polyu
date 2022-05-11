using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    bool moveLeft = false;
    bool moveRight = false;
    //public SceneFadeInOut fader;

    // Ŀǰ���⣺move����һ���Եģ�moveLeft��Ϊtrue֮��û�����ñ�Ϊfalse����Ҫ��һ�����ʵ�λ�ñ��true������
    // ����ڸú�����ģ�����ͻ�һֱmove
    public void MoveLeft()
    {
        if (!moveLeft)
        {
            transform.position = new Vector3(transform.position.x - 11, transform.position.y, transform.position.z);
            moveLeft = true;
            SceneFadeInOut.sceneEnding = true;
        }

    }

    // ����ͬ��
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
