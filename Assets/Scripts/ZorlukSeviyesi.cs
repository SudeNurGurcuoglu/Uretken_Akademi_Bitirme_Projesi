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
        // Dropdown'ýn deðeri deðiþtikçe bu fonksiyon çalýþacak
        difficultyDropdown.onValueChanged.AddListener(delegate { OnDifficultyChanged(); });

        // Baþlangýçta default süreyi ayarla
        SetGameTime(zamanSayaci);
    }

  

    void OnDifficultyChanged()
    {
        selectedValue = difficultyDropdown.value;
        //difficultyDropdown.value = 0;
        Debug.Log(selectedValue);
        // Seçilen zorluk seviyesine göre süreyi ayarla
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
        // Oyun süresini ayarla (burada sadece bir örnek olarak bir Debug.Log eklenmiþtir)
        Debug.Log("Oyun Süresi Ayarlandý: " + time);
        // Burada zamanla ilgili baþka iþlemleri gerçekleþtirebilirsiniz.
    }
}
