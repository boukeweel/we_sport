using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public List<Sprite> countdown;
    public Image countdownimage;
    public GameObject downimage;
    public float timer = 3;

    public Player_go_up player1, player2;
    private void Update()
    {
        nextscene();
        Iscorrect();
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
            }
            if (timer < 2)
            {
                countdownimage.sprite = countdown[1];
            }
            if (timer < 1)
            {
                countdownimage.sprite = countdown[2];
            }
            if (timer < 0)
            {
                countdownimage.sprite = countdown[3];
                if (timer < -1)
                {
                    LeftReady.ispressed = false;
                    RightReady.ispressed = false;
                    RightReady.isReady = false;
                    LeftReady.isReady = false;
                    downimage.SetActive(false);
                    canvas1.SetActive(false);
                    canvas2.SetActive(true);

                  
                }
               
            }
           
            
        }
        else
            timer = 3;
       
    } 
    void Iscorrect()
    {
        if (Team2OefeningText.number == 5)
        {
            
            //canvas3.SetActive(true);

            print("player2");
            player2.MoveUP();
            canvas2.SetActive(false);
            naarRandom.SetBoolean();
            Team2OefeningText.number = 0;
        }
        else if (Team1OefeningText.number == 5)
        {
            
            //canvas3.SetActive(true);
            print("palyer1");
            player1.MoveUP();
            canvas2.SetActive(false);
            naarRandom.SetBoolean();
            Team1OefeningText.number = 0;
        }
    }


}
