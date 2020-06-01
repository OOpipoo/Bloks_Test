using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
     
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            if(MovingCube.CurrentCube != null)
               MovingCube.CurrentCube.Stop();

            FindObjectOfType<CubeSpawner>().SpawnCube();
        } 
    }
}
