﻿using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public int playerOwnerNumber;

	void Awake() {
		
	}

	void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        // Destroy the whole block
        
        if(collisionInfo.gameObject.name == "Ball") {

			Player.players[playerOwnerNumber].RaiseBlockDestroyed();
        	Destroy(gameObject);
        }
    }
}
