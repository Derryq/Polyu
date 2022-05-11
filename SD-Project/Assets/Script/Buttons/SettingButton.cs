using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingButton : MonoBehaviour
{
    public GameObject Panel;
    Animator animator;
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        animator = this.GetComponent<Animator>();
    }
    public void OpenPanel()
    {
        Time.timeScale = 0;
        Debug.Log("click");
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
    public void BackToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void q()
    {
        Application.Quit();
    }

    public void ClosePanel()
    {
        Time.timeScale = 1;
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
    public void OnPointerEnter()
    {
        source.Play();
        animator.SetBool("Setting", true);
    }
    public void OnPointerExit()
    {
        animator.SetBool("Setting", false);
    }
}
