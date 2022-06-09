using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timeManagement : MonoBehaviour
{
    
    public GameObject cube;
    int counter, i = 200, X, Z;
    public float timeToChange;
    public float waitTime;
    bool Xlimit;
    // Start is called before the first frame update
    void Start()
    {
     
    }
    
    // Update is called once per frame
    void Update()
    {
        /*txtTime.text = counter.ToString();
        //Redondear el tiempo para obtener solo la parte entera
        txtTimeFloored.text = Mathf.FloorToInt(Time.time).ToString();
        //Cuenta regresiva a partir de cierto tiempo cada cierta cantidad de tiempo*/
        for (int a=10; X < a; X++);
        for (int a=9; X > a; X--);
        for (int b=7; X < b; Z++);
        for (int b = 6; X > b; Z--);
        
        if (timeToChange < Time.time)
        {
            counter++;
        }
        if (counter == i)
        {
            cube.transform.position = cube.transform.position + new Vector3(X, 0.51f, Z);
            cube.SetActive(true);
            i += 500;
        }

    }
}
