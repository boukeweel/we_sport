using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diffelculty : MonoBehaviour
{
    public bool Easy = false;
    public bool mideum = false;
    public bool hard = false;

    public GameObject DiffelcultyScreen;
    public GameObject GameScreen;


    void Start()
    {
        Easy = false;
        mideum = false;
        hard = false;
    }

    public void EasyButton()
    {
        Easy = true;
        DiffelcultyScreen.SetActive(false);
        GameScreen.SetActive(true);
    }
    public void MideumButton()
    {
        mideum = true;
        DiffelcultyScreen.SetActive(false);
        GameScreen.SetActive(true);
    }
    public void HardButton()
    {
        hard = true;
        DiffelcultyScreen.SetActive(false);
        GameScreen.SetActive(true);
    }
}
