using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EkranGecis : MonoBehaviour
{
    public void GirisSayfasi()
    {

        SceneManager.LoadScene("OyunAyarları");

    }


    public void OyunAyarları()
    {

        SceneManager.LoadScene("Game");

    }




}
