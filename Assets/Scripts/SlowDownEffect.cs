using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Effects/SlowDown")]
public class SlowDownEffect : CubesRndEffect {

    [HideInInspector]
    BallMovement ballMovement;
    public float slowForce;


    void SlowDown()
    {

        ballMovement.intensity -= slowForce;

    }

    void ResetForce()
    {

        ballMovement.intensity += slowForce;

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
