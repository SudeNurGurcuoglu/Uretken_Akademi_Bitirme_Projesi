using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PervaneRotate : MonoBehaviour
{
    
        public float donmeHizi = 100f;

        void Update()
        {
            // Pervaneyi d�nd�rme i�lemi
            transform.Rotate(Vector3.forward, donmeHizi * Time.deltaTime);
        }
    
}
