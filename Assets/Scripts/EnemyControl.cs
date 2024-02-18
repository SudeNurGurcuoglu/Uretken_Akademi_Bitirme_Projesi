using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float rotationSpeed = 2.0f;
    



    void Update()
    {
        // Düþmanýn rastgele hareket etmesi
        float horizontalMovement = Random.Range(-1.0f, 1.0f);
        float verticalMovement = Random.Range(-1.0f, 1.0f);
        Vector3 movement = new Vector3(horizontalMovement, 0, verticalMovement);
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);

        // Düþmanýn oyuncu uçaðýna dönmesi
        Vector3 direction = (Camera.main.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
    }

    
}
