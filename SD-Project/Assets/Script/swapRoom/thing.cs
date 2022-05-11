using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thing : MonoBehaviour
{
    public static bool roomChanging=false;

    //当鼠标按下时
    private void OnMouseDown()
    {
        change.Instance.MouseDown(this);  
    }

    //当鼠标在按下的状态时
    private void OnMouseEnter()
    {
        change.Instance.MouseEnter(this);      
    }

    //当鼠标释放时时
    private void OnMouseUp()
    {
        change.Instance.MouseUp();     
    }
   
    //移动动画
   public IEnumerator Move(thing positionThing, float movetime)
    {
        Vector3 startposition;
        Vector3 endposition;

        endposition = positionThing.transform.position;
        startposition = transform.position;
        for (float i = 0; i <= movetime; i += Time.deltaTime)
        {
            transform.position = Vector3.Lerp(startposition, endposition, i / movetime);    
            roomChanging=true;      
            yield return 0;
        }
        roomChanging=false;  
    }

}
