using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


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

    public Text teamtext;

    public Player_go_up player1, player2;

    public GameObject finishsceen;

    public Text team1, team2;
    

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
        finishsceen.SetActive(false);
    }

    private void Update()
    {
        TeamName1 = NameTeam1.text;
        TeamName2 = NameTeam2.text;
        PlayerWhoWon();

        team1.text = TeamName1 + " is blue";
        team2.text = TeamName2 + " is yellow";
    }

    public void PlayerWhoWon()
    {
        if(player1.traptrede == 10)
        {
            teamtext.text = TeamName1;
            GameScreen.SetActive(false);
            finishsceen.SetActive(true);
        }
        if(player2.traptrede == 10)
        {
            teamtext.text = TeamName2;
            GameScreen.SetActive(false);
            finishsceen.SetActive(true);
        }
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
        SceneManager.LoadScene(0);
        
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
        naarRandom.SetBoolean();

    }
    //zettting the diffeculty to mideum and starting the game
    public void MideumButton()
    {
        mideum = true;
        DiffelcultyScreen.SetActive(false);
        GameScreen.SetActive(true);
        DeGamezelf.SetActive(true);
        SetTeamName();
        naarRandom.SetBoolean();
    }
    //zetting the diffeculty to hard and starting the game 
    public void HardButton()
    {
        hard = true;
        DiffelcultyScreen.SetActive(false);
        GameScreen.SetActive(true);
        DeGamezelf.SetActive(true);
        SetTeamName();
        naarRandom.SetBoolean();
    }
    //zetting team names
    public void SetTeamName()
    {
        if(TeamName1 == "")
        {
            TeamName1 = "team1";
        }
        if(TeamName2 == "")
        {
            TeamName2 = "team2";
        }
    }
}
