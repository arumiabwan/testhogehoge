using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddcoinScript : MonoBehaviour {

    public Transform coins;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.Z))
        {
            Vector3 offset = new Vector3(0, 0, 1);
            Instantiate(coins, transform.position + offset, transform.rotation);

        }

	}
}
