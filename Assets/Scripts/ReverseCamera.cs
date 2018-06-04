using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Effects/ReverseCamera")]
public class ReverseCameraEffect : CubesRndEffect
{

    private Transform cameraOrientation;
    public Vector3 rotation;



    void FlipCamera()
    {

        cameraOrientation.eulerAngles -= rotation;

    }

    void ResetCameraOrientation()
    {

        cameraOrientation.eulerAngles += rotation;

    }

    public override void Initialize(GameObject camera )
    {
        cameraOrientation = camera.transform;
    }


    public override void Execute()
    {

        FlipCamera();

    }

    public override void EndEffect()
    {

        ResetCameraOrientation();

    }




}



