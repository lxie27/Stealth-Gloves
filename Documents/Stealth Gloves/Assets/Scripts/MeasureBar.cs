using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureBar : MonoBehaviour {

    int measured;
    GameObject gm;

    // Use this for initialization
    void Start () {
        gm = GameObject.Find("Game Manager");
    }
	
	// Update is called once per frame
	void Update () {
        //transform.localScale = (0, measured, 0);
        measured = gm.GetComponent<GameManager>().key;
        transform.localScale = new Vector3(0.5f, measured, 0.1f);
	}
}
