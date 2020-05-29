using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuletteBall : MonoBehaviour {

    public float speed = 40.0f;

    // Use this for initialization
    void Start () {
        RuletteStart();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RuletteStart() {
        this.GetComponent<Rigidbody>().AddForce(
            (-transform.forward) * speed,
            ForceMode.VelocityChange);
        
    }
}
