using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureBar : MonoBehaviour {
    
    public char fkey;
    public float measured;
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

        Vector3 position = transform.position;
        transform.position = new Vector3(position[0], measured/2f, position[2]);
        ChangeColor();
	}

    private void ChangeColor()
    {
        Color updateColor = Color.red;
        if (measured <= 2f)
        {
            rend.material.color = Color.green;
        }
        else if (measured <= 5f)
        {
            rend.material.color = Color.yellow;
        }
        else
        {
            rend.material.color = Color.red;
        }
    }
}
