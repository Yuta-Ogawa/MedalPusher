using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    public void BallStart() {
        this.gameObject.transform.DOMove(new Vector3(9f, 9f, 0.3f), 3.0f);
        this.gameObject.transform.DORotate(new Vector3(90f, 0, 0), 3.0f, mode: RotateMode.FastBeyond360);
        
    }
}
