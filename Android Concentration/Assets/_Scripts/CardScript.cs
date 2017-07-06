using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour {

    // Use this for initialization
    GameObject card;
    Rigidbody cardRB;
	void Start () {
        cardRB= GetComponent<Rigidbody>();
    }
	
    public void flip () {
        cardRB.MoveRotation(new Quaternion(0, 180, 0, 180));
    }
	// Update is called once per frame
	void Update () {
	    
	}
}
