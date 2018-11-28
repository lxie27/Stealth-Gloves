using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int qq = 0;
    public int ww = 0;
    public int ee = 0;
    public int rr = 0;
    public int vv = 0;
    public int uu = 0;
    public int ii = 0;
    public int oo = 0;
    public int pp = 0;
    public int nn = 0;
    
    public bool keyPressed = false;

    // Use this for initialization
    void Start () {
        InvokeRepeating("Decrement", 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            keyPressed = true;
            qq += 1;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            keyPressed = true;
            ww += 1;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            keyPressed = true;
            ee += 1;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            keyPressed = true;
            rr += 1;
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            keyPressed = true;
            vv += 1;
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            keyPressed = true;
            uu += 1;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            keyPressed = true;
            ii += 1;
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            keyPressed = true;
            oo += 1;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            keyPressed = true;
            pp += 1;
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            keyPressed = true;
            nn += 1;
        }

        keyPressed = false;


    }

    private void Decrement()
    {
        if (qq > 0 && !keyPressed)
        {
            qq -= 1;
        }
        if (ww > 0 && !keyPressed)
        {
            ww -= 1;
        }
        if (ee > 0 && !keyPressed)
        {
            ee -= 1;
        }
        if (rr > 0 && !keyPressed)
        {
            rr -= 1;
        }
        if (vv > 0 && !keyPressed)
        {
            vv -= 1;
        }
    }
}
