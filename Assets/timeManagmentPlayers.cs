using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeManagmentPlayers : MonoBehaviour
{
    public GameObject player1, player2, boost1;
    public Text textoMancha, tiempo, lost;
    float mancha1=0, mancha2=14, i=1, speedMovement;
    // Start is called before the first frame update
    void Start()
    {
         
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time == mancha1)
        {
            mancha1 += 14-i;
            mancha2 += 14 - i;
            i += 1;
        }
        

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
        }
        else if (Time.time > mancha2 && Time.time > mancha1)
        { 
            if (col.gameObject.name == "Player1")
            {
                //player1.SetActive(false);
                lost.text = "Player1 ha perdido";
            }
            
        }
    }
}
