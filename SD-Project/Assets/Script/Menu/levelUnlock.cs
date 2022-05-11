using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelUnlock : MonoBehaviour
{
    public Button[] lvlButtons;

    // Start is called before the first frame update
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 1);

        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 1 > levelAt)
            {
                lvlButtons[i].interactable = false;
            }              
        }
    }

    public void deletePlayerPrefs()
    {
       PlayerPrefs.DeleteKey("levelAt");
       StartCoroutine(DelaySceneLoad());
    }

    IEnumerator DelaySceneLoad()
    {
        //SceneFader.sceneEnding = true;
        yield return new WaitForSeconds(1f);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("MenuScene");
    }
}
