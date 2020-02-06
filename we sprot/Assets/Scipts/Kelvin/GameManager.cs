using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject plankingTimer;
    public List<Sprite> countdown;
    public Image go;
    public Image countdownimage;
    public GameObject downimage;
    public float timer = 3;

    public GameObject jumpingjacks, lunchlady, omabestrong,pushup,situps;

    public Player_go_up player1, player2;

    public GameObject imagesgo;

    public static bool alesuit;

    private void Update() 
    {
        WelkeAanZetten();
        nextscene();
        Iscorrect();
    }
    public void WelkeAanZetten()
    {
        if(alesuit == false)
        {
            if (Row.stoppedSlot == "JumpingJacks")
            {
                print("Jaditwerkt");
                jumpingjacks.SetActive(true);
                lunchlady.SetActive(false);
                omabestrong.SetActive(false);
                pushup.SetActive(false);
                situps.SetActive(false);
                
            }
            if (Row.stoppedSlot == "Lunges")
            {
                lunchlady.SetActive(true);
                jumpingjacks.SetActive(false);
                omabestrong.SetActive(false);
                pushup.SetActive(false);
                situps.SetActive(false);
            }
            if (Row.stoppedSlot == "Planken")
            {
                omabestrong.SetActive(true);
                lunchlady.SetActive(false);
                jumpingjacks.SetActive(false);
                pushup.SetActive(false);
                situps.SetActive(false);
              
            }
            if(Row.stoppedSlot == "Sit Ups")
            {
                omabestrong.SetActive(false);
                lunchlady.SetActive(false);
                jumpingjacks.SetActive(false);
                pushup.SetActive(false);
                situps.SetActive(true);
            }
            if(Row.stoppedSlot == "Push Ups")
            {
                omabestrong.SetActive(false);
                lunchlady.SetActive(false);
                jumpingjacks.SetActive(false);
                pushup.SetActive(true);
                situps.SetActive(false);
            }
        }
        
    }
    private void AllesUit()
    {
        alesuit = true;
        //print("werkt?");
        omabestrong.SetActive(false);
        lunchlady.SetActive(false);
        jumpingjacks.SetActive(false);
        pushup.SetActive(false);
        situps.SetActive(false);
    }
    private void nextscene()
    {

        if (RightReady.isReady && LeftReady.isReady)
        {
            timer = timer - Time.deltaTime;
            downimage.SetActive(true);
            if (timer < 3)
            {
                countdownimage.sprite = countdown[0];
                imagesgo.SetActive(false);
                PlankingTimer.starttimer = false;
                plankingTimer.SetActive(false);
            }
            if (timer < 2)
            {
                countdownimage.sprite = countdown[1];
                imagesgo.SetActive(false);
            }
            if (timer < 1)
            {
                countdownimage.sprite = countdown[2];
                imagesgo.SetActive(false);
            }
            if (timer < 0)
            {
                downimage.SetActive(false);
                imagesgo.SetActive(true);
                go.sprite = countdown[3];

                if (timer < -1)
                {
                    LeftReady.ispressed = false;
                    RightReady.ispressed = false;
                    RightReady.isReady = false;
                    LeftReady.isReady = false;
                    downimage.SetActive(false);
                    imagesgo.SetActive(false);
                    canvas1.SetActive(false);
                    canvas2.SetActive(true);
                    plankingTimer.SetActive(true);
                    PlankingTimer.starttimer = true;
                }
            }

        }
        else
            timer = 3;
    } 
    void Iscorrect()
    {
        if (Team2OefeningText.number == UIManger.moeilijkhijd)
        {
            
            //canvas3.SetActive(true);
            
            //print("player2");
            Team2OefeningText.number = 0;
            Team1OefeningText.number = 0;
            AllesUit();
            player2.MoveUP();
            canvas2.SetActive(false);
            naarRandom.SetBoolean();
            
        }
        else if (Team1OefeningText.number == UIManger.moeilijkhijd)
        {
            
            //canvas3.SetActive(true);
            //print("palyer1");
            Team1OefeningText.number = 0;
            Team2OefeningText.number = 0;
            AllesUit();
            player1.MoveUP();
            canvas2.SetActive(false);
            naarRandom.SetBoolean();
            
        }
    }


}
