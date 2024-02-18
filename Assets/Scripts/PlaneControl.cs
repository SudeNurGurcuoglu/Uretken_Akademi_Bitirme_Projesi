using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UcakScript : MonoBehaviour
{
    public float speed;
    public float maxSpeed;
    public float minSpeed;
    public float rotSpeed;
    public float rotSpeed2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ucag�n h�zlanma islemleri

        if (Input.GetKey(KeyCode.W))
        {
            if (speed < maxSpeed)
            
                speed++;
            

        }


        if (Input.GetKey(KeyCode.S))
        {
            if (speed >minSpeed)

                speed--;


        }

        //speed h�z� min de�erden d���kse ya da maks de�erden y�ksekteyse 
        speed -= transform.forward.y * Time.deltaTime * 50f;
        if (speed < minSpeed/2) 
            speed = minSpeed;   
        if (speed < maxSpeed*2)
            speed = maxSpeed;



        //u�a��n ileriye do�ru hareketi
        transform.position += transform.forward * Time.deltaTime*speed;

        //sa�a sola yukar� asa��ya d�nme kodlar�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward*Time.deltaTime*rotSpeed);  
        
        }
         
        if (Input.GetKey(KeyCode.RightArrow))

        {
            transform.Rotate(Vector3.back * Time.deltaTime * rotSpeed);

        }

        if (Input.GetKey(KeyCode.UpArrow))

        {
            transform.Rotate(Vector3.left * Time.deltaTime * rotSpeed);

        }
        if (Input.GetKey(KeyCode.DownArrow))

        {
            transform.Rotate(Vector3.right * Time.deltaTime * rotSpeed);

        }

        //uca��n kendi etraf�nda d�nmesi

        if (Input.GetKey(KeyCode.A))

        {
            transform.Rotate(-Vector3.up * Time.deltaTime * rotSpeed2);

        }

        if (Input.GetKey(KeyCode.D))

        {
            transform.Rotate(-Vector3.down * Time.deltaTime * rotSpeed2);

        }




    }
}
