﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {
    static RoomManager instance;
    public static float RoomNorth { get { return instance.CurrentRoomNorth; } }

    //where north is in local coordinates
    public float CurrentRoomNorth;
	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
