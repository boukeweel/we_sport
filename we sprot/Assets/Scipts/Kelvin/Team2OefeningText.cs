using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Team2OefeningText : MonoBehaviour
{
    public static int number = 0;
    public List<Sprite> numbers;
    public Image ding, ding2;
    private int getal;
    private int getal2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        getal = number;
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            number++;
        }




        if (number == 10)
        {
            ding.sprite = numbers[0];
            ding2.sprite = numbers[1];
        }
        else if (number == 11)
        {
            ding.sprite = numbers[1];
            ding2.sprite = numbers[1];
        }
        else if (number == 12)
        {
            ding.sprite = numbers[2];
            ding2.sprite = numbers[1];
        }
        else if (number == 13)
        {
            ding.sprite = numbers[3];
            ding2.sprite = numbers[1];
        }
        else if (number == 14)
        {
            ding.sprite = numbers[4];
            ding2.sprite = numbers[1];
        }
        else if (number == 15)
        {
            ding.sprite = numbers[5];
            ding2.sprite = numbers[1];
        }
        else
        {
            ding.sprite = numbers[number];
            ding2.sprite = numbers[0];
        }

    }
}
