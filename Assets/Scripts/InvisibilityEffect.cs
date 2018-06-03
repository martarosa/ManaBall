using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Effects/InvisibilityEffect")]
public class InvisibilityEffect : CubesRndEffect
{

    
    public Transform player;



    void MakeInvisible()
    {

        player.GetComponent<MeshRenderer>().enabled = false;

    }

    public override void Execute()
    {

        MakeInvisible();

    }






}
