using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    float movementSpeed=0.1f, rotationSpeed=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }

    }

    void OnCollisionEnter(Collision col)
    {
        /*if (col.gameObject.name == "boost1")
        {
            tiempo = Time.time;
            boost1.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+1)            
            {
                movementSpeed = 0.2f;
            }
            else
            {
                movementSpeed = 0.1f;
            }
        }
        if (col.gameObject.name == "death")
        {
            CloneObject();
        }
    }

    public int i = 3;
    public void CloneObject()
    {
        while (i > 0)
        {
            i--;
            Debug.Log(i);
            Instantiate(player2);
        }
    }*/
    }
}

