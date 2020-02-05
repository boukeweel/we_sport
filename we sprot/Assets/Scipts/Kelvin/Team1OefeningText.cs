using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Team1OefeningText : MonoBehaviour
{
    private int number = 0;
    public List<Sprite> numbers;
    public Image ding;
    private int getal;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            number++;
            getal = number;
            ding.sprite = numbers[getal];
        }
    }
}
