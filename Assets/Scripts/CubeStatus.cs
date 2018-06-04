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


    IEnumerator EffectCO()
    {

        effect.Execute();
        yield return new WaitForSecondsRealtime(effect.effectDuration);
        effect.EndEffect();
        yield return null;
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (effect != null)
            {
                StartCoroutine(EffectCO());

            }

            gameManager.CountScore(score);
            if (finalCube == true)
            {
                gameManager.FinalCube(finalScore);
            }

            transform.position = new Vector3(1000,1000,1000);
        }

    }

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

    }




}
