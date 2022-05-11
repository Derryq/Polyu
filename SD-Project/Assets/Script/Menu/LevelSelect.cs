using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
   // Use this for initialization
	void Start () {
        
    }

    public void Level1()
    {
        SceneManager.LoadScene("level1");//level1为我们要切换到的场景
    }

    public void Level2()
    {
        SceneManager.LoadScene("level2_1");//level1为我们要切换到的场景
    }

    public void Level3()
    {
        SceneManager.LoadScene("level2_2");//level1为我们要切换到的场景
    }

    public void Level4()
    {
        SceneManager.LoadScene("level3");//level1为我们要切换到的场景
    }

    public void Level5()
    {
        SceneManager.LoadScene("level5");//level1为我们要切换到的场景
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");//level1为我们要切换到的场景
    }
}
