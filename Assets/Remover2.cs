using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Remover2 : MonoBehaviour {

    public GameObject scoreText;
    ScoreScript scoreS;
    float startTime;


    // Use this for initialization
    void Start () {
        scoreS = scoreText.GetComponent<ScoreScript>();
        Invoke("OnTriggerEnter", 5);
        
    }

    // Update is called once per frame
    void Update () {
        startTime += Time.deltaTime;
	}

    void OnTriggerEnter(Collider other) {
        if (startTime <= 5) {
            Destroy(other.gameObject);
            return;
        }
        if (other.gameObject.tag == "CoinTag") {
            Destroy(other.gameObject);
            scoreS.addScore(1);
        }else if(other.gameObject.tag == "BallTag"){
            Destroy(other.gameObject);
        }
        Debug.Log("a");


    }

}

