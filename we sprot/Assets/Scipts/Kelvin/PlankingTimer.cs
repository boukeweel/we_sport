using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlankingTimer : MonoBehaviour
{
    public static float time;

    private string minutes;
    private string seconds;

    public Text text;

    public static bool starttimer = false;

    public GameObject gehaaldScene;
    public GameObject plankingScene;

    private void Start()
    {
        text = GetComponent<Text>();
        Mathf.Clamp(time, 1f, 1000f);
        time = UIManger.timer;
    }

    void Update()
    {
        if (starttimer == true)
        {
            CountDown();
        }
        if (time < 0)
        {
            gehaaldScene.SetActive(true);
            plankingScene.SetActive(false);
        }
    }

    public void CountDown()
    {
        
        Mathf.Clamp(time, 0f, 1000f);

        time -= Time.deltaTime;

        minutes = Mathf.Floor(time / 60).ToString("00");
        seconds = (time % 60).ToString("00");

        text.text = "Timer " + minutes +":" + seconds; 
    }

}
