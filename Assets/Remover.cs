using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Remover : MonoBehaviour {
    public GameObject mainCamObj;

    // Use this for initialization
    void Start () {
        mainCamObj = Camera.main.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "BallTag") {
            mainCamObj.transform.DOMove(new Vector3(0, 4f, -10f), 3.0f);
            mainCamObj.transform.DORotate(new Vector3(0, 0, 0), 3.0f, mode: RotateMode.FastBeyond360);
            Destroy(other.gameObject);
        }else if(other.gameObject.tag == "CoinTag") {
            Destroy(other.gameObject);
        }
    }
}
