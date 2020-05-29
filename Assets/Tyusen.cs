using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyusen : MonoBehaviour {
    GameObject slot;
    float startTime;
    

        // Use this for initialization
        void Start () {
        slot = GameObject.Find("Slot");
    }
	
	// Update is called once per frame
	void Update () {
        startTime += Time.deltaTime;
	}

    private void OnTriggerEnter(Collider other) {
        if (startTime <= 5) {
            return;
        }
        if (other.gameObject.tag == "CoinTag") {
            slot.GetComponent<Slot>().StartSlot();
        }
    }
}
