using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public int color = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            ++color;
            if (color == 0)
            {
                GetComponent<Renderer>().material.color = Color.red;
            } else if (color == 1)
            {
                GetComponent<Renderer>().material.color = Color.yellow;
            } else if (color == 2)
            {
                GetComponent<Renderer>().material.color = Color.green;
            } else if (color == 3)
            {
                GetComponent<Renderer>().material.color = Color.blue;
            } else if (color == 4)
            {
                GetComponent<Renderer>().material.color = Color.magenta;
            } else if (color == 5)
            {
                GetComponent<Renderer>().material.color = Color.white;
                color = -1;
            } else
            {
                GetComponent<Renderer>().material.color = new Color(212, 199, 244);
            }
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            if (GetComponent<Renderer>().isVisible)
            {
                GetComponent<MeshRenderer>().enabled = false;
            } else
            {
                GetComponent<Renderer>().enabled = true;
            }
        }
    }
}
