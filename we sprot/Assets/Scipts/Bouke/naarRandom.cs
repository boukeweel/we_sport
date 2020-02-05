using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naarRandom : MonoBehaviour
{
    public GameObject StairScene;
    public GameObject randomding;

    float time_wait;
     static bool active;

    public static void SetBoolean()
    {
        active = true;
    }
    public void Update()
    {
        if(active == true)
        {
            time_wait += Time.deltaTime;
            if(time_wait > 5)
            {
                StairScene.SetActive(false);
                randomding.SetActive(true);
                active = false;
                time_wait = 0;
            }
        }
        
    }

}
