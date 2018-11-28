using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureBar : MonoBehaviour {

    public int measured;
    GameObject gm;
    Renderer rend; 

    // Use this for initialization
    void Start () {
        gm = GameObject.Find("Game Manager");
        Color color = Color.green;
        rend = GetComponent<Renderer>();
        //rend.material.color = color;
    }
	
	// Update is called once per frame
	void Update () {
        //transform.localScale = (0, measured, 0);
        measured = gm.GetComponent<GameManager>().key;
        transform.localScale = new Vector3(0.5f, measured, 0.1f);
        ChangeColor();
	}

    private void ChangeColor()
    {
        Color updateColor = Color.red;
        if (measured <= 5)
        {
            rend.material.color = Color.green;
        }
        else if (measured <= 10)
        {
            rend.material.color = Color.yellow;
        }
        else
        {
            rend.material.color = Color.red;
        }
    }
}
