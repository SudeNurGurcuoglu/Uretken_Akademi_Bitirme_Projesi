using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsSettings : MonoBehaviour
{
    // Start is called before the first frame update

    public Text volumeAmount;
    public Slider slider;


    private void Start()
    {
        Debug.Log("Start method called.");
        LoadAudio();
    }


    public void SetAudio(float value)
    {
        AudioListener.volume= value;
        volumeAmount.text = ((int)value).ToString();


    }
   private void SaveAudio()
    {
        Debug.Log("SaveAudio method called.");
        PlayerPrefs.SetFloat("audioVolume",AudioListener.volume);
    
    
    }
    private void LoadAudio()
    {
        Debug.Log("SaveAudio method called.");
        if (PlayerPrefs.HasKey("audioVolume"))
        {
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            slider.value = PlayerPrefs.GetFloat("audioVolume");
        }
       else
        {
            PlayerPrefs.SetFloat("audioVolume",0.5f);
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            slider.value = PlayerPrefs.GetFloat("audioVolume");
        }

    }
}
