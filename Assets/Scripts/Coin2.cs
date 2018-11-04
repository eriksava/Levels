using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player"){

            GameManager.instance1.IncrementScore();
            GameManager.instance1.SaveData();
            Destroy(gameObject);

        }
    }
}
