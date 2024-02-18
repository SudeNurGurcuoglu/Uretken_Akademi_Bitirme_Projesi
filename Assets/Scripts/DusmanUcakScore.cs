using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanUcakSkore : MonoBehaviour
{
    public Transform mermiSpawnNoktasi;
    // Start is called before the first frame update
    public class DusmanUcak : MonoBehaviour
    {
        public int skorDegeri = 10;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Mermi"))
            {
                Destroy(other.gameObject); // Mermiyi yok et
                SkorArttir();
            }
        }

        void SkorArttir()
        {
            ScoreManager.skor += skorDegeri;
            Debug.Log("Skor: " + ScoreManager.skor);
        }
    }
    public class ScoreManager : MonoBehaviour
    {
        public static int skor = 0;
    }
}
