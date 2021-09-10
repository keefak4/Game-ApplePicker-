using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class LoadSceneToLevel : MonoBehaviour
{
   public void _ClickToLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void _ClickToLevelOne()
    {
        SceneManager.LoadScene(2);
    }
    public void _ClickToLevelTwo()
    {
        SceneManager.LoadScene(3);
    }
    public void _ClickToLevelTree()
    {
        SceneManager.LoadScene(4);
    }
}
