using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public int nextSceneLoad;
    public GameObject wall;
    private AudioSource source;
    public GameObject EndPanel;
    Animator animator;

    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
        source = GetComponent<AudioSource>();
        animator = EndPanel.GetComponent<Animator>();
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            source.Play();
            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
            //StartCoroutine(DelaySceneLoad());
            if (EndPanel != null)
           {
                EndPanel.SetActive(true);
                StartCoroutine(DelayRobotAnim());
            }
        }
    }

    public void LoadNextScene()
    {
        StartCoroutine(DelaySceneLoad());
    }

    IEnumerator DelaySceneLoad()
    {
        //SceneFader.sceneEnding = true;
        yield return new WaitForSeconds(1f);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(nextSceneLoad);
    }
    IEnumerator DelayRobotAnim()
    {
        yield return new WaitForSeconds(1.5f);
        animator.SetTrigger("Robot");
    }
}
