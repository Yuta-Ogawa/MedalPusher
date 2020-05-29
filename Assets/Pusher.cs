using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour {
    private Vector3 origin;
    // Use this for initialization
    void Start () {
        origin = GetComponent<Transform>().position;

    }
	
	// Update is called once per frame
	void Update () {
        Vector3 offset = new Vector3(0, 0, Mathf.Sin(Time.time) * 0.5f);
        GetComponent<Rigidbody>().MovePosition(origin + offset);


    }
}
