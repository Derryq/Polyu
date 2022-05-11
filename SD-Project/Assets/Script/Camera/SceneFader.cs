using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneFader : MonoBehaviour
{
    public float fadeSpeed = 1.5f;
    public bool sceneStarting = true;
    public static bool sceneEnding = false;
    public RawImage rawImage;

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

    public void FadeToClear()
    {
        rawImage.color = Color.Lerp(rawImage.color, Color.clear, fadeSpeed * Time.deltaTime);
    }

    public void FadeToBlack()
    {
        rawImage.color = Color.Lerp(rawImage.color, Color.black, 10000000f * Time.deltaTime);
    }

    public void StartScene()
    {
        FadeToClear();
        if (rawImage.color.a < 0.05f)
        {
            rawImage.color = Color.clear;
            rawImage.enabled = false;
            sceneStarting = false;
        }
    }

    public void EndScene()
    {
        rawImage.enabled = true;
        FadeToBlack();
        if (rawImage.color.a > 0.95f)
        {
            sceneEnding = false;
            sceneStarting = true;
        }
    }

    void OnDestroy()
    {

    }
}
