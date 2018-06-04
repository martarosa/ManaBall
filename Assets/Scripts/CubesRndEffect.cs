using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public enum CubeEffects { SLOWDOWN, SPEEDUP, INVISIBILITY, FLIPCAMERA

}

public class CubesRndEffect : ScriptableObject
{
    public CubeEffects effectNumber;
    public float effectDuration=5;
    [Range(0, 1)]
    public float probability;


    public virtual void Initialize(GameObject player)
    {


    }

    public virtual void Execute()
    {

    }

    public virtual void EndEffect()
    {


    }

}


