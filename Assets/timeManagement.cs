using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timeManagement : MonoBehaviour
{
    
    public GameObject boost1,player1, player2;
    int counter, i = 200, X, Z;
    public float timeToChange;
    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
     
    }
    // Update is called once per frame
    void Update()
    {              
        if (timeToChange < Time.time)
        {
            counter++;
        }
        if (counter == i)
        {            
            boost1.SetActive(true);
            i += 500;
        }
                
    }
    
}
