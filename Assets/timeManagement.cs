using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timeManagement : MonoBehaviour
{
    public Text txtTime;
    public Text txtTimeFloored;
    public GameObject cube;
    int counter, i = 200;
    public float timeToChange;
    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        txtTime.text = counter.ToString();
        //Redondear el tiempo para obtener solo la parte entera
        txtTimeFloored.text = Mathf.FloorToInt(Time.time).ToString();
        //Cuenta regresiva a partir de cierto tiempo cada cierta cantidad de tiempo
        if (timeToChange < Time.time)
        {
            counter++;
        }
        if (counter == i)
        {
            cube.SetActive(true);
            transform.position 
            i += 500;
        }

    }
}
