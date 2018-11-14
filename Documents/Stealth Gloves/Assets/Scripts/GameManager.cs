using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static int qq = 0;
    public static int ww = 0;
    public static int ee = 0;
    public static int rr = 0;
    public static int vv = 0;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Q))
        {
            qq == qq + 1;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            ww == ww + 1;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ee == ee + 1;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            rr == rr + 1;
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            vv == vv + 1;
        }
    }
}
