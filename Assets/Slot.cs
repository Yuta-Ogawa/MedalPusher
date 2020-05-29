using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Slot : MonoBehaviour {
    public GameObject ball;
    public GameObject getCoin;
    public void StartSlot() {
        int count = Random.Range(1, 20);
        GetComponent<TextMesh>().text = count.ToString();
        if(count ==7) {
            Selectseven();
        } else if (count % 2 == 0) {
            SelectEven();
        }
    }
    
    void Selectseven() {
        GameObject ballclone = Instantiate(ball);
        ballclone.transform.position = GameObject.Find("BallPosition").transform.position;
    }
    void SelectEven() {
        GameObject getCoinclone = Instantiate(getCoin);
        getCoinclone.transform.position = GameObject.Find("GetCoinPosition").transform.position;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space")) {
            Selectseven();
        }
    }

    
}
