using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddcoinScript2 : MonoBehaviour {

    public Transform coins;

    // Use this for initialization
    void Start () {
        transform.Rotate(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.X))
        {
            Vector3 offset = new Vector3(0, 0, 1);

            Instantiate(coins, transform.position + offset, transform.rotation);

        }

    }
}
