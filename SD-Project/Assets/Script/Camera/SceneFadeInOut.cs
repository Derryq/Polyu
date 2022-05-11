using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


//淡入淡出，目前还没啥大问题
public class SceneFadeInOut : MonoBehaviour
{
    public float fadeSpeed = 1.5f;
    public bool sceneStarting = true;
    public static bool sceneEnding = false;
    private RawImage rawImage;
    void Awake()
    {
        rawImage = GetComponent<RawImage>();
    }

    void Start()
    {
    }

    void Update()
    {
        if (sceneStarting)
        {
            StartScene();
        }

        if (sceneEnding)
        {
            EndScene();
        }
    }

    private void FadeToClear()
    {
        rawImage.color = Color.Lerp(rawImage.color, Color.clear, fadeSpeed * Time.deltaTime);
    }

    private void FadeToBlack()
    {
        rawImage.color = Color.Lerp(rawImage.color, Color.black, 10000000f * Time.deltaTime);
    }

    void StartScene()
    {
        FadeToClear();
        if (rawImage.color.a < 0.05f)
        {
            rawImage.color = Color.clear;
            rawImage.enabled = false;
            sceneStarting = false;
        }
    }

    void EndScene()
    {
        rawImage.enabled = true;
        FadeToBlack();
        //FadeToClear();
        if (rawImage.color.a > 0.95f)
        {
            sceneEnding = false;
            sceneStarting = true;
            //SceneManager.LoadScene("level1_Room");
            //FadeToClear();

        }
    }

    void OnDestroy()
    {

    }
}
