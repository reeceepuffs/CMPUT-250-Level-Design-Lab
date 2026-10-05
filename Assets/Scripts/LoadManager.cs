using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadManager : MonoBehaviour
{
    public TopDownPlayerBehaviour player;
    private string timeStringVar;

    // Start is called before the first frame update
    void Awake()
    {
        if (SceneManager.GetActiveScene().name == "Intro Level")
        {
            PlayerPrefs.SetString("time", "");
        }

        timeStringVar = PlayerPrefs.GetString("time");

        TopDownUITimeBehaviour timescript = Object.FindObjectOfType<TopDownUITimeBehaviour>();

        timescript.time = float.Parse(timeStringVar);
    }
}
