using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeManagmentPlayers : MonoBehaviour
{
    public GameObject player1, player2, boost1;
    public Text textoMancha, tiempo, lost;
    float mancha1=0, mancha2=14, speedMovement;
    // Start is called before the first frame update
    void Start()
    {
         
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo.text = Mathf.FloorToInt(Time.time).ToString();
        if (Time.time > mancha1 && Time.time <= mancha2)
        {
            textoMancha.text = "Player1 es la mancha";
        }
        else if (Time.time > mancha2 && Time.time > mancha1)
        {
            textoMancha.text = "Player2 es la mancha";
        }
        /*while(Time.time < mancha1)
       {
           textoMancha.text = "Player1 es la mancha";
       }
       while (Time.time < mancha2)
       {
           textoMancha.text = "Player2 es la mancha";
       }*/
    }

    void OnCollisionEnter(Collision col)
    {
        if (Time.time > mancha1 && Time.time <= mancha2)
        { 
            if (col.gameObject.name == "Player2")
            {
                lost.text = "Player 2 ha perdido";
            }
            /*if (col.gameObject.name == "boost1")
            {
                boost1.SetActive(false);
                for (int i = 2; Time.time < Time.time + i; i++)
                {
                    speedMovement = 0.2f;
                    if (Input.GetKey(KeyCode.W))
                    {
                        transform.Translate(0, 0, speedMovement);
                    }
                    if (Input.GetKey(KeyCode.S))
                    {
                        transform.Translate(0, 0, -speedMovement);
                    }
                }
            }*/
        }
        else if (Time.time > mancha2 && Time.time > mancha1)
        { 
            if (col.gameObject.name == "Player1")
            {
                //player1.SetActive(false);
                lost.text = "Player1 ha perdido";
            }
            if (col.gameObject.name == "boost1")
            {
                boost1.SetActive(false);
                for(int i=2; Time.time < Time.time +i; i++)
                {
                    speedMovement= 0.2f;
                    if (Input.GetKey(KeyCode.W))
                    {
                        transform.Translate(0, 0, speedMovement);
                    }
                    if (Input.GetKey(KeyCode.S))
                    {
                        transform.Translate(0, 0, -speedMovement);
                    }
                }
            }
        }
    }
}
