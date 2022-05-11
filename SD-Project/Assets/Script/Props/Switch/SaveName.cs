using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveName : MonoBehaviour
{
    public Password input;
    public GameObject psw;
    public bool IsRight = false;
    AudioSource OpenDoorSound;
    public GameObject error;
    public GameObject right;
   // private AudioSource source;
    AudioSource OpenDoorSound2;
    public GameObject painting;
    Scene scene;
    //private AudioSource source2;

    void Awake()
    {
        OpenDoorSound = error.GetComponent<AudioSource>();
        OpenDoorSound2 = right.GetComponent<AudioSource>();
        //source = GetComponent<AudioSource>();
        scene = SceneManager.GetActiveScene();
        //source2 = GetComponent<AudioSource>();
    }

    public void submitName()
    {
        if (scene.name == "level3")
        {
            if (input.psw == "tel" || input.psw == "TEL")
            {
                print("Right");
                IsRight = true;
                psw.SetActive(false);
                OpenDoorSound2.Play();
                //Destroy(psw);
                //source.PlayOneShot(OpenDoorSound2, 0.3F);
            }
            else
            {
                print("Wrong");
                IsRight = false;
                OpenDoorSound.Play();
                //source.PlayOneShot(OpenDoorSound, 0.3F);
            }
        }

        if (scene.name == "level2_2")
        {
            if (input.psw == "boy" || input.psw == "BOY")
            {
                print("Right");
                IsRight = true;
                psw.SetActive(false);
                OpenDoorSound2.Play();
                //Destroy(psw);
                //source.PlayOneShot(OpenDoorSound2, 0.3F);
            }
            else
            {

                print("Wrong");
                IsRight = false;
                OpenDoorSound.Play();
                //source.PlayOneShot(OpenDoorSound, 0.3F);
            }
        }

    }

    public void exitpsw()
    {
        painting.GetComponent<BoxCollider2D>().enabled = true;
        psw.SetActive(false);
    }
}
