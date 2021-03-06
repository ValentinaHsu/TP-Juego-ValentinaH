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
        if (Time.time == mancha1)
        {
            mancha1 += 14 - i;
            mancha2 += 14 - i;
            i += 1;
        }

        tiempo.text = Mathf.FloorToInt(Time.time).ToString();

        if (Time.time > mancha1 && Time.time <= mancha2)
        {
            textoMancha.text = "Player1 es la mancha";
        }    
            
        if (Time.time > mancha2 && Time.time > mancha1)
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
                CloneObject(player2);
                lost.text = "Player 2 ha perdido";
                
            }            
        }
        if (Time.time > mancha2 && Time.time > mancha1)
        { 
            if (col.gameObject.name == "Player1")
            {
                //player1.SetActive(false);
                lost.text = "Player1 ha perdido";
                CloneObject(player1);   
            }
            
        }
    }

    public int u = 3;
    public void CloneObject(GameObject player)
    {
        float a = 0.5f;
        while (u > 0)
        {
            player1.transform.localScale = new Vector3(a, a, a);
            a -= 0.1f;
            u--;
            Debug.Log(i);
            Instantiate(player);
        }
    }
}
