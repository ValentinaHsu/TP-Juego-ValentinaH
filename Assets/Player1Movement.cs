
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1Movement : MonoBehaviour
{
    float movementSpeed = 0.1f, rotationSpeed=5;
    public GameObject player2, boost1;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
    }

    /*void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.name == "boost1")
        {
            boost1.SetActive(false);
        }
    }*/
}
