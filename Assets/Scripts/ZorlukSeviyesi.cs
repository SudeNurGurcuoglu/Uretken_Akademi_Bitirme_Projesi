using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ZorlukSeviyesi : MonoBehaviour
{
    public TMP_Dropdown difficultyDropdown;
    public float zamanSayaci = 500f;
    public Text zaman;
    int selectedValue;

    void Start()
    {
        //difficultyDropdown = GetComponent<TMP_Dropdown>();
        selectedValue = 0;
        PlayerPrefs.SetFloat("zaman_Sayaci", 500f);
        // Dropdown'�n de�eri de�i�tik�e bu fonksiyon �al��acak
        difficultyDropdown.onValueChanged.AddListener(delegate { OnDifficultyChanged(); });

        // Ba�lang��ta default s�reyi ayarla
        SetGameTime(zamanSayaci);
    }

  

    void OnDifficultyChanged()
    {
        selectedValue = difficultyDropdown.value;
        //difficultyDropdown.value = 0;
        Debug.Log(selectedValue);
        // Se�ilen zorluk seviyesine g�re s�reyi ayarla
        if (selectedValue == 0)
{
            PlayerPrefs.SetFloat("zaman_Sayaci", 500f);
            //zamanSayaci = 500f;
            //zamanSayaci -= Time.deltaTime;
            //zaman.text = "TIME:" + (int)zamanSayaci;
            Debug.Log("a-sda-213-1");
            Debug.Log(difficultyDropdown.value);

        }
else if (selectedValue == 1)
        {
            PlayerPrefs.SetFloat("zaman_Sayaci", 300f);
            //zamanSayaci = 300f;
            //zamanSayaci -= Time.deltaTime;
            //zaman.text = "TIME:" + (int)zamanSayaci;
            Debug.Log("a-sda-213-1");
        }
else if (selectedValue == 2)
        {
            PlayerPrefs.SetFloat("zaman_Sayaci", 200f);
            //zamanSayaci = 200f;
            //zamanSayaci -= Time.deltaTime;
            //zaman.text = "TIME:" + (int)zamanSayaci;
            
        }
        Debug.Log(difficultyDropdown.value);
     
    }

    void SetGameTime(float time)
    {
        // Oyun s�resini ayarla (burada sadece bir �rnek olarak bir Debug.Log eklenmi�tir)
        Debug.Log("Oyun S�resi Ayarland�: " + time);
        // Burada zamanla ilgili ba�ka i�lemleri ger�ekle�tirebilirsiniz.
    }
}
