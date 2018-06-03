using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStatus : MonoBehaviour {


    //attributi

    public int maxLives;


    int currentLives;
    Vector3 respawnPosition;
    BallMovement myMovement;


    //metodi

    public void SetRespawnPosition(Vector3 ceckPointPosition)
    {

        respawnPosition = ceckPointPosition;

    }

    
    public void ResetPosition()
    {
        UpdateCurrentLives();
        transform.position = respawnPosition;
        myMovement.StopBall();

    }
    


    public int GetCurrentLives()
    {
        return currentLives;
    }


    public void UpdateCurrentLives()
    {
        currentLives -= 1;
    }


    private void Start()
    {

        myMovement = GetComponent<BallMovement>();
        currentLives = maxLives;

    }

}
