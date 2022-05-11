using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReplayController : MonoBehaviour
{
    Animator animator;
    GameObject player;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
        animator = this.GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }
 

    public void OnClick()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
    }
    public void OnPointerEnter()
    {
        source.Play();
        animator.SetBool("Replay", true);
    }
    public void OnPointerExit()
    {
        animator.SetBool("Replay", false);
    }
}
