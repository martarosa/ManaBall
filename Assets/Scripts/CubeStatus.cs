using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeStatus : MonoBehaviour {

    public bool finalCube;
    public int score;
    public int finalScore;

    public CubesRndEffect effect;

    GameManager gameManager;




    public int GetScore()
    {
        return score;
    }

    public int getFinalScore()
    {
        return finalScore;
    }

    public void SetEffect(CubesRndEffect effetto)
    {

        effect = effetto;

    }





    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            effect.Execute();
            gameManager.CountScore(score);
            if (finalCube == true)
            {
                gameManager.FinalCube(finalScore);
            }

            this.gameObject.SetActive(false);
        }

    }

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

    }




}
