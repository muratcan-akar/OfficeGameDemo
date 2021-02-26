using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Kontrol : MonoBehaviour
{
     public Transform Player;
     public float MouseHassasiyet;
     public float xRotation = 0f;

    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
       
        float mauseX = Input.GetAxis("Mouse X")*MouseHassasiyet*Time.deltaTime;
        float mauseY = Input.GetAxis("Mouse Y")*MouseHassasiyet * Time.deltaTime;
        xRotation -= mauseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        Player.Rotate(Vector3.up * mauseX);
    }
}