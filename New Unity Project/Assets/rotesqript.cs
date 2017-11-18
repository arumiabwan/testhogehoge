using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotesqript : MonoBehaviour {

    private Vector3 origin;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        origin= new Vector3(0, 0, Mathf.Sin(Time.time));
        transform.Rotate(origin);
	}
}
