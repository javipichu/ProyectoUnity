﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour {

private Rigidbody rb;
private int count;
public float speed;
public Text countText;
public Text winText;
	void SetCountText(){
		countText.text="Score : " + count.ToString();
		if (count >= 18) {
            winText.text = "CRACK !!";
        rb.gameObject.SetActive(false);

        }
	}

	void Start () {
		rb = GetComponent<Rigidbody>();
		count=0;
		SetCountText();
		
       

	}
	
	void Update () {
		 float moveHorizontal = Input.GetAxis("Horizontal");
 		float moveVertical = Input.GetAxis("Vertical");
 		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
 		rb.AddForce(movement * speed);
	}
	void OnTriggerEnter(Collider other) {
 		if (other.gameObject.tag == "PickUp") {
 		other.gameObject.SetActive(false);
 		count = count +1;
 		SetCountText(); 
 		}
		if (other.gameObject.tag =="caida"){
			winText.text="GAME OVER!";
			rb.gameObject.SetActive(false);
		}

}
}
