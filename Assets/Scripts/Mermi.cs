using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{
    public int mermiHizi = 50;
    void Update()
    {
        transform.Translate(Vector3.forward * mermiHizi * Time.deltaTime);
        Destroy(gameObject, 13f);
    }
}
