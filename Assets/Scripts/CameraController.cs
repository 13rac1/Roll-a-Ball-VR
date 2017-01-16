﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame after Update() has completed
	void Update () {
        transform.position = player.transform.position + offset;
	}
}
