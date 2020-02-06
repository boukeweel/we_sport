using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_go_up : MonoBehaviour
{

    public Transform[] pos;

    public int traptrede = 0;

    

    
    
    public void MoveUP()
    {
        traptrede++;
        transform.position = pos[traptrede].position;

    }
    
}
