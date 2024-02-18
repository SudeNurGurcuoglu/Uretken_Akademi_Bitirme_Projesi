using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeData : MonoBehaviour
{
    private float zamanSayaci;
    public Text zaman;

    private void Start()
    {
        zamanSayaci = PlayerPrefs.GetFloat("zaman_Sayaci");
        PlayerPrefs.DeleteAll();
    }
    private void Update()
    {
        zamanSayaci-= Time.deltaTime;
        zaman.text = "TIME:" + (int)zamanSayaci;
    }
}
