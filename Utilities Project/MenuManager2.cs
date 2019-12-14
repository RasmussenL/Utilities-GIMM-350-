using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuManager2 : MonoBehaviour
{
    //public Slider brightnessSlider;
    public Light brightness;
    public GameObject[] panels;
    float testNum = 1f;
    public Text enemyScore;
    public bool sound = true;
    //public SoundManager soundManager;

    public void openPanel(string panelName)
    {
        foreach(GameObject go in panels)
        {
            if(go.name == panelName)
            {
                go.SetActive(true);
            }
            else
            {
                go.SetActive(false);
            }
        }
    }
    public void resumeGame()
    {
        Time.timeScale = 1;
        openPanel("");
    }
    public void quit()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            openPanel("MainMenu");
        }
        //pause time
        //open main menu when user hits escape
        enemyScore.text = "Enemy Score: " + GameManager.Instance.alienDeathCounter.ToString();
    }
    public void AdjustBrightness(float newB)
    {
        //brightness.intensity = num;
        brightness.intensity = newB;
    }

    //public void SoundToggle()
    //{
    //    if (!sound)
    //    {
    //        soundManager. = true;
    //        sound = true;
    //    }
    //    else
    //    {
    //        soundManager.enabled = false;
    //        sound = false;
    //    }
    //}
}
