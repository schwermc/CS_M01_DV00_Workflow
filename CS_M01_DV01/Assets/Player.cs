using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * 0.25f;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * 0.25f;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * 0.25f;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * 0.25f;
        }
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.RightShift))
        {
            transform.position += Vector3.up * 0.25f;
        }
        if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.RightControl))
        {
            transform.position += Vector3.down * 0.25f;
        }
    }
}
