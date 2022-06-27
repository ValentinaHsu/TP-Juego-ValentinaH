using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public AudioClip bt2;
    AudioSource source;
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
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "death")
        {
            CloneObject(player2);
        }

        if (coll.gameObject.name == "boost2")
        {
            source.clip = bt2;
            source.Play();
            tiempo = Time.time;
            boost2.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+sec)            
            {
                movementSpeed = 0.2f;
            }
        }
        if (coll.gameObject.name == "boost4")
        {
            source.clip = bt2;
            source.Play();
            tiempo = Time.time;
            boost4.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+sec)            
            {
                movementSpeed = 0.2f;
            }
        }
        if (coll.gameObject.name == "boost6")
        {
            source.clip = bt2;
            source.Play();
            tiempo = Time.time;
            boost6.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+sec)            
            {
                movementSpeed = 0.2f;
            }
        }

        if (coll.gameObject.name == "boost1")
        {
            source.clip = bt2;
            source.Play();
            tiempo = Time.time;
            boost1.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+1)            
            {
                movementSpeed = 0.06f;
            }

        }
        if (coll.gameObject.name == "boost3")
        {
            source.clip = bt2;
            source.Play();
            tiempo = Time.time;
            boost3.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+1)            
            {
                movementSpeed = 0.06f;
            }

        }
        if (coll.gameObject.name == "boost6")
        {
            source.clip = bt2;
            source.Play();
            tiempo = Time.time;
            boost4.SetActive(false);
            if (Time.time < tiempo + 1)
            //while (Time.time < tiempo+1)            
            {
                movementSpeed = 0.06f;
            }

        }
    }

    public int i = 3;
    public void CloneObject(GameObject player)
    {
        float a = 0.5f;
        while (i > 0)
        {
            player.transform.localScale = new Vector3(a, a, a);
            a -= 0.1f;
            i--;
            Debug.Log(i);
            Instantiate(player);
        }
    }
}

