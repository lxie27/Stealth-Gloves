using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureBar : MonoBehaviour {
    GameObject gm = GameObject.Find("GameManager");

    int measured = gm.GetComponent<GameManager>().key;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = (0, measured, 0);
	}
}
