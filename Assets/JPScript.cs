using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JPScript : MonoBehaviour {

    private GameObject stateText;
    public GameObject scoreText;
    ScoreScript scoreS;

    // Use this for initialization
    void Start () {
        this.stateText = GameObject.Find("RuletteText");
        scoreS = scoreText.GetComponent<ScoreScript>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "BallTag") {
            this.stateText.GetComponent<TextMesh>().text = "JackPot!!\r\n1000枚獲得!!";
            scoreS.addScore(1000);
        }
    }
}
