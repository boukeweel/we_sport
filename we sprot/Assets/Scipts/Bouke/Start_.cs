using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Start_ : MonoBehaviour
{
    public GameObject G_start;
    public GameObject Difelculty;
    public GameObject exit;

    private void Start()
    {
        G_start.SetActive(true);
        exit.SetActive(false);
        Difelculty.SetActive(false);
    }

    public void StartKnop()
    {
        G_start.SetActive(false);
        Difelculty.SetActive(true);
    }
    public void ExitKnop()
    {
        G_start.SetActive(false);
        exit.SetActive(true);
    }
    public void Back()
    {
        exit.SetActive(false);
        G_start.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
