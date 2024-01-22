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
        if (Input.GetKey(KeyCode.C))
        {
            ++color;
            if (color == 0)
            {
                GetComponent<Renderer>().material.color = Color.magenta;
            } else if (color == 1)
            {
                GetComponent<Renderer>().material.color = Color.yellow;
            } else if (color == 2)
            {
                color = -1;
                GetComponent<Renderer>().material.color = Color.blue;
            }
        }
    }
}
