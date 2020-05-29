using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour {

    public GameObject coinPrefab;
    public float speed = 10.0f;
    public GameObject coinclone1;
    public GameObject coinclone2;

    public GameObject scoreText;
    ScoreScript scoreS;

   void CoinG(string PositionName) {
        coinclone1=Instantiate(coinPrefab);

        coinclone1.transform.position = GameObject.Find(PositionName).transform.position;
        coinclone1.GetComponent<Rigidbody>().AddForce((transform.up) * speed, ForceMode.VelocityChange);
        Debug.Log("速度1: " + coinclone1.GetComponent<Rigidbody>().velocity.magnitude);
        scoreS.subScore(1);

    }






    // Use this for initialization
    void Start() {
        scoreS = scoreText.GetComponent<ScoreScript>();

    }
    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.RightArrow)) {
            speed += 0.2f;
            Debug.Log(speed);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow)) {
            CoinG("CoinPosition1");
            speed = 5;


        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            speed += 0.2f;
            Debug.Log(speed);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow)) {
            CoinG("CoinPosition2");
            speed = 5;
        }
    }
}


