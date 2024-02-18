using UnityEngine;
using UnityEngine.SceneManagement;

public class UcakAtes : MonoBehaviour
{
    public GameObject mermiPrefab;
    public Transform atesNoktasi;
    public float mermiHizi = 20f;
  

    void Update()
    {
        AtesEtKontrolu();
    }

    void AtesEtKontrolu()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AtesEt();
        }
    }

    void AtesEt()
    {
        GameObject yeniMermi = Instantiate(mermiPrefab, atesNoktasi.position, atesNoktasi.rotation);
    }
   
}
