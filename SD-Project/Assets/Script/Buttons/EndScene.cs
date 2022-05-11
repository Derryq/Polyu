using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void q()
    {
        Application.Quit();
    }

}
