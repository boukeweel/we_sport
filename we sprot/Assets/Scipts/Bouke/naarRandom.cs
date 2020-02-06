using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naarRandom : MonoBehaviour
{
    public GameObject StairScene;
    public GameObject randomding;

    float time_wait;
    static bool active;

    public Player_go_up p1, p2;


    private void Start()
    {
        active = false;
    }
    public static void SetBoolean()
    {
        active = true;
    }
    public void Update()
    {
        if(active == true)
        {
            if(p1.traptrede < 10 && p2.traptrede < 10)
            {
                StairScene.SetActive(true);
                randomding.SetActive(false);
                time_wait += Time.deltaTime;
                if (time_wait > 4)
                {
                    StairScene.SetActive(false);
                    randomding.SetActive(true);
                    active = false;
                    time_wait = 0;
                }
            }
            
            
            
        }
        
        
    }

}
