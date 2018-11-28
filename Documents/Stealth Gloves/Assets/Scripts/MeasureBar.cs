using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureBar : MonoBehaviour {

    public char fkey;
    int measured;
    GameObject gm;

    // Use this for initialization
    void Start () {
        gm = GameObject.Find("Game Manager");
        
    }
	
	// Update is called once per frame
	void Update () {
        if (fkey == 'q')
        {
            measured = gm.GetComponent<GameManager>().qq;
        }
        else if (fkey == 'w')
        {
            measured = gm.GetComponent<GameManager>().ww;
        }
        else if (fkey == 'e')
        {
            measured = gm.GetComponent<GameManager>().ee;
        }
        else if (fkey == 'r')
        {
            measured = gm.GetComponent<GameManager>().rr;
        }
        else if (fkey == 'v')
        {
            measured = gm.GetComponent<GameManager>().vv;
        }
        else if (fkey == 'u')
        {
            measured = gm.GetComponent<GameManager>().uu;
        }
        else if (fkey == 'i')
        {
            measured = gm.GetComponent<GameManager>().ii;
        }
        else if (fkey == 'o')
        {
            measured = gm.GetComponent<GameManager>().oo;
        }
        else if (fkey == 'p')
        {
            measured = gm.GetComponent<GameManager>().pp;
        }
        else if (fkey == 'n')
        {
            measured = gm.GetComponent<GameManager>().nn;
        }
        transform.localScale = new Vector3(0.5f, measured, 0.1f);
	}
}
