using System.Collections;

using UnityEngine;

public class Pusher : MonoBehaviour {

    // Use this for initialization

    //default position
    private Vector3 origin;

    void Start () {

        origin = transform.position;

	}
	
	// Update is called once per frame
	void Update () {

        Vector3 offset = new Vector3(0, 0, 2*Mathf.Sin(Time.time));
        transform.position = origin + offset;//rigidbody.MovePosition(origin + offset);

	}
}
