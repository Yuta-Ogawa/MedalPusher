using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCoin : MonoBehaviour {
    public GameObject coin2Prefab;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 10; i++) {
            coin2Prefab.transform.position = new Vector3(Random.Range(-2, 2), 2.3f, Random.Range(1, 3));
            GameObject coin = Instantiate(coin2Prefab) as GameObject;
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
