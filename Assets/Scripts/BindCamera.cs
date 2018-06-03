using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindCamera : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    void CameraPosition()
    {

        transform.position = player.transform.position + offset;



    }

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;

    }
	
	// Update is called once per frame
	void LateUpdate () {

        CameraPosition();
	}
}
