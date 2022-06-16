
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1Movement : MonoBehaviour
{
    float rotationSpeed = 5, tiempo;
    public float movementSpeed = 0.1f;
    public GameObject player1, player2, boost1, boost2, boost3, boost4, boost5, boost6;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //time += Time.deltaTime;
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

    public float sec=1;
    void OnCollisionEnter(Collision col)
    {
        /*  if (Input.GetKeyDown(KeyCode.T))
        {
            charController.$$anonymous$$ove(forward$$anonymous$$ovement * dashSpeed * Time.deltaTime);
        }*/
        if (col.gameObject.name == "death")
        {
            CloneObject();
        }

        if (col.gameObject.name == "boost1")
        {
            tiempo = Time.time;
            boost1.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+sec)            
            {
                movementSpeed = 0.15f;
            }            
        }
        if (col.gameObject.name == "boost3")
        {
            tiempo = Time.time;
            boost3.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+sec)            
            {
                movementSpeed = 0.15f;
            }
        }
        if (col.gameObject.name == "boost5")
        {
            tiempo = Time.time;
            boost5.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+sec)            
            {
                movementSpeed = 0.15f;
            }
        }

        if (col.gameObject.name == "boost2")
        {
            tiempo = Time.time;
            boost2.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+1)            
            {
                movementSpeed = 0.06f;
            }
            
        }
        if (col.gameObject.name == "boost4")
        {
            tiempo = Time.time;
            boost4.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+1)            
            {
                movementSpeed = 0.06f;
            }

        }
        if (col.gameObject.name == "boost6")
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
            player1.transform.localScale = new Vector3(a,a,a);
            a -= 0.1f;
            i--;
            Debug.Log(i);
            Instantiate(player1);
        }
    }
}
