using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timeManagement : MonoBehaviour
{
    public Vector3 originalPosition1, originalPosition2;
    public GameObject boost1, boost2, boost3, boost4, boost5, boost6, player1, player2;
    int counter, i = 200, a=600, b=800;
    public float timeToChange, waitTime;
    // Start is called before the first frame update
    void Start()
    {
        /*originalPosition1 = boost1.transform.localPosition;
        pbx1 = originalPosition1.x;
        pbz1 = originalPosition1.z;
        originalPosition2 = boost2.transform.localPosition;
        pbx2 = originalPosition2.x;
        pbz2 = originalPosition2.z;*/

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
            /*boost1.transform.position = new Vector3(pbx1, 0.51f, pbz1);
            boost2.transform.position = new Vector3(pbx2, 0.51f, pbz2);*/
            boost1.SetActive(true);
            boost2.SetActive(true);
            i += 600;
        }

        if (counter == a)
        {
            boost3.SetActive(true);
            boost4.SetActive(true);
            i += 800;
        }

        if (counter == b)
        {
            boost5.SetActive(true);
            boost6.SetActive(true);
            i += 300;
        }

    }
    
}
