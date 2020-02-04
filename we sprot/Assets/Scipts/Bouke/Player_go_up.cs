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
            
        }
    }
    public void MoveUP()
    {
        traptrede++;
        transform.position = pos[traptrede].position;

    }
}
