using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingArea : MonoBehaviour {

    GameManager gameManager;

	// Use this for initialization
	void Start () 
    {

        gameManager = FindObjectOfType<GameManager>();
		
	}
	

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            gameManager.KeepPlaying();

        }

    }



}
