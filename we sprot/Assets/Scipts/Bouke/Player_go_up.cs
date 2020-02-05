using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_go_up : MonoBehaviour
{

    public Transform[] pos;

    public int traptrede = 0;

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(traptrede < 10)
            {
                
                MoveUP();
                
            }
            if (traptrede == 10)
            {
                WinPlayer();
            }
            
        }
    }
    public void MoveUP()
    {
        traptrede++;
        transform.position = pos[traptrede].position;

    }
    public void WinPlayer()
    {

    }
}
