using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Effects/InvisibilityEffect")]
public class InvisibilityEffect : CubesRndEffect
{

    
    MeshRenderer renderer;



    void MakeInvisible()
    {

        renderer.enabled = false;

    }


    void ResetVisible()
    {

        renderer.enabled = true;

    }


    public override void Initialize(GameObject target)
    {
        renderer = target.GetComponent<MeshRenderer>();
    }

    public override void Execute()
    {

        MakeInvisible();

    }



    public override void EndEffect()
    {
        
        ResetVisible();

    }


}
