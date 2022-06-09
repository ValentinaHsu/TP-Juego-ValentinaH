
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    float movementSpeed=0.2f, rotationSpeed;
    public GameObject player2, boost1;


    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, movementSpeed);
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player2")
        {
            Destroy(player2);
        }
        if (col.gameObject.name == "boost1")
        {
            boost1.SetActive(false); 
        }
    }
}
