using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuidePanel : MonoBehaviour
{
    Animator animator;
    public GameObject TextGuide;
    private AudioSource source;
    public GameObject ClueHint;
    public GameObject ClueSheet;
    // Start is called before the first frame update
    void Start()
    {
       source = GetComponent<AudioSource>();
       animator = this.GetComponent<Animator>();
       //ClueHint = GameObject.FindGameObjectWithTag("ClueHint");
    }

    // Update is called once per frame
    void Update()
    {
        if (ClueHint != null && ClueSheet != null)
        {
            if(!ClueSheet.activeSelf)
            {
                ClueHint.SetActive(false);
            }       
        }
    }

     public void OnPointerEnter()
    {
        source.Play();
        animator.SetBool("Guide", true);
        if (TextGuide != null)
        {
            TextGuide.SetActive(true);
        }
    }
    public void OnPointerExit()
    {
      if (TextGuide != null)
        {
            TextGuide.SetActive(false);
        }
        animator.SetBool("Guide", false);
    }
    public void ShowClueHint()
    {
        if (ClueHint != null && ClueSheet != null)
        {
             bool active = ClueHint.activeSelf;
             ClueHint.SetActive(!active);
        }
    }
}
