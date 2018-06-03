using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Effects/SpeedUp")]
public class SpeedUpEffect : CubesRndEffect
{

    //[HideInInspector]
    public BallMovement ballMovement;
    public float speedForce;


    void SlowDown()
    {

        ballMovement.intensity = speedForce;

    }

    public override void Execute()
    {

        SlowDown();

    }

}
