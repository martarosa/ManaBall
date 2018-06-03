using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Transform[] checkPoints;
    public BallStatus playerStatus;
    public BallMovement playerMovement;

    //text 

    public Text scoreText;
    public Text winText;

    // cubes effects

    public CubesRndEffect[] allEffects;
    

    //--------------private var-----------

    int score;
    int ncubes;
    int ncubesInPlay;
    int nStdCubes;


    GameObject finalCube;
    //--------------------------------------

    void InitializeEffects()
    {
        foreach (CubesRndEffect eff in allEffects)
        {

            switch (eff.effectNumber)
            {
                case CubeEffects.SLOWDOWN:
                    SlowDownEffect slowEff = (SlowDownEffect)eff;
                    slowEff.ballMovement=playerMovement;
                    break;
                case CubeEffects.SPEEDUP:
                    SpeedUpEffect speedEff = (SpeedUpEffect)eff;
                    speedEff.ballMovement = playerMovement;
                    break;
                case CubeEffects.INVISIBILITY:
                    InvisibilityEffect invisibleEff = (InvisibilityEffect)eff;
                    invisibleEff.player = playerMovement.gameObject.transform;
                    break;
                default:
                    break;
            }



        }
        

    }


    void AssignEffects(GameObject[] cubes)
    {
        float rndValue = 0;
        foreach (GameObject cube in cubes)
        {
            rndValue = Random.value;
            if (rndValue <= 0.25)
            {
                cube.GetComponent<CubeStatus>().SetEffect(allEffects[(int)CubeEffects.SLOWDOWN]);
            }

            else if ((0.25 < rndValue) && (rndValue <= 0.50))
            {

                cube.GetComponent<CubeStatus>().SetEffect(allEffects[(int)CubeEffects.SPEEDUP]);

            }

            else if ((0.50 < rndValue) && (rndValue <= 0.75))
            {

                cube.GetComponent<CubeStatus>().SetEffect(allEffects[(int)CubeEffects.INVISIBILITY]);

            }

        }
    

    }

    public void KeepPlaying()
    {
        

        if (playerStatus.GetCurrentLives() > 1)
        {

            playerStatus.ResetPosition();

        }

        else

        {

            winText.text = "You Loose";

        }

    }

    public void CountScore(int cubeScore)
    {
        
        ncubesInPlay -= 1;
        score = score + cubeScore;
        
        if (ncubesInPlay == 0)
        {

            finalCube.SetActive(true);

        }
        scoreText.text = "Score: " + score.ToString();
        
    }

    public void FinalCube(int finalScore)
    {

        
        score = score + finalScore;
        scoreText.text = "Score: " + score.ToString();
        winText.text = "You Win!!";
        //if (score >= ncubes)
        //{
        //    winText.text = "You Win with Max Score!!";
        //}

    }
 
    void HideCheckPoints()
    {

        foreach (Transform ch in checkPoints)
        {

            ch.GetComponent<MeshRenderer>().enabled = false;

        }

    }

    // Use this for initialization
    void Start () {

        finalCube = GameObject.FindGameObjectWithTag("finalCube");
        InitializeEffects();


        playerStatus.SetRespawnPosition(checkPoints[0].position);
        finalCube.SetActive(false);

        score = 0;
        scoreText.text = "Score: " + score.ToString();
        winText.text = " ";

        HideCheckPoints();

        GameObject[] cubi = GameObject.FindGameObjectsWithTag("cube");
 //       GameObject[] finalcube = GameObject.FindGameObjectsWithTag("finalCube");
        nStdCubes = cubi.Length;
        //ncubes = cubi.Length + finalcube.Length;
        ncubesInPlay = nStdCubes;
        AssignEffects(cubi);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
