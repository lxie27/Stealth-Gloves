using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public float qq = 0;
    public float ww = 0;
    public float ee = 0;
    public float rr = 0;
    public float vv = 0;
    public float uu = 0;
    public float ii = 0;
    public float oo = 0;
    public float pp = 0;
    public float nn = 0;
    
    public bool keyPressed = false;
    public static float measureTotal;
    
    // Use this for initialization
    void Start () {
        InvokeRepeating("Decrement", .1f, .015f);
	}
	
	// Update is called once per frame
	void Update () {

        measureTotal = qq + ww + ee + rr + vv + uu + ii + oo + pp + nn;

        if (Input.GetKeyDown(KeyCode.Q) && qq < 6.5f)
        {
            keyPressed = true;
            qq += 1f;
        }

        if (Input.GetKeyDown(KeyCode.W) && ww < 6.5f)
        {
            keyPressed = true;
            ww += 1f;
        }

        if (Input.GetKeyDown(KeyCode.E) && ee < 6.5f)
        {
            keyPressed = true;
            ee += 1f;
        }

        if (Input.GetKeyDown(KeyCode.R) && rr < 6.5f)
        {
            keyPressed = true;
            rr += 1f;
        }

        if (Input.GetKeyDown(KeyCode.V) && vv < 6.5f)
        {
            keyPressed = true;
            vv += 1f;
        }

        if (Input.GetKeyDown(KeyCode.U) && uu < 6.0f)
        {
            keyPressed = true;
            uu += 1f;
        }

        if (Input.GetKeyDown(KeyCode.I) && ii < 6.5f)
        {
            keyPressed = true;
            ii += 1f;
        }

        if (Input.GetKeyDown(KeyCode.O) && oo < 6.5f)
        {
            keyPressed = true;
            oo += 1f;
        }

        if (Input.GetKeyDown(KeyCode.P) && pp < 6.5f)
        {
            keyPressed = true;
            pp += 1f;
        }

        if (Input.GetKeyDown(KeyCode.N) && nn < 6.5f)
        {
            keyPressed = true;
            nn += 1f;
        }

        keyPressed = false;

    }

    private void Decrement()
    {
        float dec = .05f;

        if (qq > 0 && !keyPressed)
        {
            qq -= dec;
        }
        if (ww > 0 && !keyPressed)
        {
            ww -= dec;
        }
        if (ee > 0 && !keyPressed)
        {
            ee -= dec;
        }
        if (rr > 0 && !keyPressed)
        {
            rr -= dec;
        }
        if (vv > 0 && !keyPressed)
        {
            vv -= dec;
        }
        if (uu > 0 && !keyPressed)
        {
            uu -= dec;
        }
        if (ii > 0 && !keyPressed)
        {
            ii -= dec;
        }
        if (oo > 0 && !keyPressed)
        {
            oo -= dec;
        }
        if (pp > 0 && !keyPressed)
        {
            pp -= dec;
        }
        if (nn > 0 && !keyPressed)
        {
            nn -= dec;
        }
    }
}


