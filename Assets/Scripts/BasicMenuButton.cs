using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicMenuButton : MonoBehaviour
{
    public string level;
    public void StartGame(){
        PlayerPrefs.SetString("currentLevel", level);
        level = PlayerPrefs.GetString("currentLevel");
        SceneManager.LoadScene(level);
    }
}
