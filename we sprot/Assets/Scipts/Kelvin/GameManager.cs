using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public List<Sprite> countdown;
    public Image countdownimage;
    public GameObject downimage;
    public float timer = 3;
    private void Update()
    {
        nextscene();
        
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
                    RightReady.isReady = false;
                    downimage.SetActive(false);
                    canvas1.SetActive(false);
                    canvas2.SetActive(true);
                  
                }
               
            }
           
            
        }
        else
            timer = 3;
       
    } 

}
