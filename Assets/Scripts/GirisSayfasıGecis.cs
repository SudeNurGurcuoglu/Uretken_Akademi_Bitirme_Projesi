using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EkranGecis : MonoBehaviour
{
    public void GirisSayfasi()
    {

        SceneManager.LoadScene("OyunAyarlar�");

    }


    public void OyunAyarlar�()
    {

        SceneManager.LoadScene("Game");

    }




}
