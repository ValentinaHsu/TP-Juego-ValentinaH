using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    float movementSpeed=0.1f, rotationSpeed=5;
    public GameObject boost1, boost2, boost3, boost4, boost5, boost6, player2;
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

    float tiempo;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "death")
        {
            CloneObject();
        }

        if (col.gameObject.name == "boost2")
        {
            tiempo = Time.time;
            boost1.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+sec)            
            {
                movementSpeed = 0.15f;
            }
        }
        if (col.gameObject.name == "boost4")
        {
            tiempo = Time.time;
            boost3.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+sec)            
            {
                movementSpeed = 0.15f;
            }
        }
        if (col.gameObject.name == "boost6")
        {
            tiempo = Time.time;
            boost5.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+sec)            
            {
                movementSpeed = 0.15f;
            }
        }

        if (col.gameObject.name == "boost1")
        {
            tiempo = Time.time;
            boost2.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+1)            
            {
                movementSpeed = 0.06f;
            }

        }
        if (col.gameObject.name == "boost3")
        {
            tiempo = Time.time;
            boost4.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+1)            
            {
                movementSpeed = 0.06f;
            }

        }
        if (col.gameObject.name == "boost4")
        {
            tiempo = Time.time;
            boost6.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+1)            
            {
                movementSpeed = 0.06f;
            }

        }
    }

    public int i = 3;
    public void CloneObject()
    {
        float a = 0.5f;
        while (i > 0)
        {
            player2.transform.localScale = new Vector3(a, a, a);
            a -= 0.1f;
            i--;
            Debug.Log(i);
            Instantiate(player2);
        }
    }
}

