using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PopPropertyGridWhenMouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Animator animator;
    private bool _isEnter;
    private float _timer;

    void Update()
    {
        _timer += Time.deltaTime;


        if (_isEnter && _timer - 1.0f > 0f)
        {
            Debug.Log("Open");
            animator.SetTrigger("Open");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _timer = 0;
        _isEnter = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _isEnter = false;
        Debug.Log("Close");
        animator.SetTrigger("Close");
    }
}
