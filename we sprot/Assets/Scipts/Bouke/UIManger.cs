using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManger : MonoBehaviour
{
    public GameObject DeGamezelf;

    public bool Easy = false;
    public bool mideum = false;
    public bool hard = false;

    public GameObject DiffelcultyScreen;
    public GameObject GameScreen;

    public GameObject G_start;
    
    public GameObject exit;

    public InputField NameTeam1;
    public InputField NameTeam2;

    public string TeamName1;
    public string TeamName2;

    //zetting all things that need to be zet
    private void Start()
    {
        G_start.SetActive(true);
        exit.SetActive(false);
        DiffelcultyScreen.SetActive(false);
        Easy = false;
        mideum = false;
        hard = false;
        DeGamezelf.SetActive(false);
    }

    private void Update()
    {
        TeamName1 = NameTeam1.text;
        TeamName2 = NameTeam2.text;
        
    }

    // Startbutton to Diffuclty screen
    public void StartKnop()
    {
        G_start.SetActive(false);
        DiffelcultyScreen.SetActive(true);
    }
    //exit button in the start screen going to the exit screen
    public void ExitKnop()
    {
        G_start.SetActive(false);
        exit.SetActive(true);
    }
    //in the exit screen the no button going to the start screen
    public void Back()
    {
        exit.SetActive(false);
        G_start.SetActive(true);
    }
    //closing the apllication
    public void Exit()
    {
        Application.Quit();
    }
    //zetting the diffeculty to easy and starting the game
    public void EasyButton()
    {
        Easy = true;
        DiffelcultyScreen.SetActive(false);
        GameScreen.SetActive(true);
        DeGamezelf.SetActive(true);
        SetTeamName();
    }
    //zettting the diffeculty to mideum and starting the game
    public void MideumButton()
    {
        mideum = true;
        DiffelcultyScreen.SetActive(false);
        GameScreen.SetActive(true);
        DeGamezelf.SetActive(true);
        SetTeamName();
    }
    //zetting the diffeculty to hard and starting the game 
    public void HardButton()
    {
        hard = true;
        DiffelcultyScreen.SetActive(false);
        GameScreen.SetActive(true);
        DeGamezelf.SetActive(true);
        SetTeamName();
    }
    //zetting team names
    public void SetTeamName()
    {
        if(TeamName1 == null)
        {
            TeamName1 = "team1";
        }
        if(TeamName2 == null)
        {
            TeamName2 = "team2";
        }
    }
}
