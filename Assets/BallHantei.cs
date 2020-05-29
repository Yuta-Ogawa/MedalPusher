using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHantei : MonoBehaviour {
    public GameObject mainCamObj;
    public GameObject ruletteBall;

    public void RuletteBallStart() {
        GameObject ruletteBallclone = Instantiate(ruletteBall) as GameObject;
        ruletteBallclone.transform.position = GameObject.Find("RuletteBallPosition").transform.position;
    }
    // Use this for initialization
    void Start() {
        mainCamObj = Camera.main.gameObject;
        
    }

    // Update is called once per frame
    void Update() {

    }

    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "BallTag") {
            mainCamObj.GetComponent<CameraController>().BallStart();
            RuletteBallStart();
            ruletteBall.GetComponent<RuletteBall>().RuletteStart();
            
        }
            
    }
}
