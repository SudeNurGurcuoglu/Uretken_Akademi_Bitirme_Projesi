using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{

    public Text zaman,Puan;
    public  float zamanSayaci=500F;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        zaman.text = "TIME:"+ (int)zamanSayaci;
    }
}
