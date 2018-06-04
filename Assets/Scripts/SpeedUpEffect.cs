using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Effects/SpeedUp")]
public class SpeedUpEffect : CubesRndEffect
{

    //[HideInInspector]
    BallMovement ballMovement;
    public float speedForce;


    void SlowDown()
    {

        ballMovement.intensity += speedForce;

    }

    void ResetForce()
    {

        ballMovement.intensity -= speedForce;

    }

    public override void Initialize(GameObject target)
    {
        ballMovement = target.GetComponent<BallMovement>();
    }


    public override void Execute()
    {

        SlowDown();

    }

    public override void EndEffect()
    {

        ResetForce();

    }

}
