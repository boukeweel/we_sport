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
    public  float timer = 5;
    public GameObject stairs;
    public GameObject gehaald;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        PlankingTimer.time = UIManger.timer;
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Ltext.SetActive(false);
            LDone.SetActive(true);
            p1.MoveUP();
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Rtext.SetActive(false);
            RDone.SetActive(true);
            p2.MoveUP();
        }
        if (timer < 0)
        {
            naarRandom.SetBoolean();
            gehaald.SetActive(false);
        }
    }
}
