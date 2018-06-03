using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Effects/SlowDown")]
public class SlowDownEffect : CubesRndEffect {

    [HideInInspector]
    public BallMovement ballMovement;
    public float slowForce;


    void SlowDown()
    {

        ballMovement.intensity = slowForce;

    }

    public override void Execute()
    {

        SlowDown();

    }

}
