using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinistIt : MonoBehaviour
{
    public GameObject Ltext;
    public GameObject Rtext;
    public GameObject LDone;
    public GameObject RDone;
    public Player_go_up p1,p2;
    public  static float timer = 5;
    
    public GameObject gehaald;
    public GameObject timerding;

    public static bool test = false;
    private static bool ispressed1;
    private static bool ispressed2;
    // Start is called before the first frame update
    void Start()
    {
    }

    public static void SetBooleans()
    {
        test = true;
        timer = 5;
        ispressed2 = false;
        ispressed1 = false;
    }
    void Update()
    {
        if(test == true)
        {
            timer = timer - Time.deltaTime;
            //PlankingTimer.time = UIManger.timer;
            PlankingTimer.Test();
            timerding.SetActive(false);
            if (Input.GetKeyDown(KeyCode.LeftShift)&& !ispressed1)
            {
                Ltext.SetActive(false);
                LDone.SetActive(true);
                p1.MoveUP();
                ispressed1 = true;
            }
           
            if (Input.GetKeyDown(KeyCode.RightShift)&& !ispressed2)
            {
                Rtext.SetActive(false);
                RDone.SetActive(true);
                p2.MoveUP();
                ispressed2 = true;
            }
           
            if (timer < 0)
            {
                GameManager.eventest = false;
                test = false;
                naarRandom.SetBoolean();
                gehaald.SetActive(false);
                if (ispressed2)
                {
                    Rtext.SetActive(true);
                    RDone.SetActive(false);
                }
                if (ispressed1)
                {
                    Ltext.SetActive(true);
                    LDone.SetActive(false);
                }
            }
        }
        
    }
}
