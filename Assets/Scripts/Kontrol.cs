using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kontrol : MonoBehaviour
{
    public Transform kamera;
    public Transform Player;
    public float yatay;
     public float dikey;
    public float YurumeHizi;
    Rigidbody yercekimi;
  

    void Start()
    {
        yercekimi = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {       
        yatay = Input.GetAxisRaw("Horizontal");
         dikey = Input.GetAxisRaw("Vertical");

        //  Vector3 vec = new Vector3(yatay*YurumeHizi*Time.deltaTime, 0, dikey * YurumeHizi * Time.deltaTime);

        //  yercekimi.velocity = vec;
        transform.Translate(yatay * Time.deltaTime, 0, dikey * Time.deltaTime);
        kamera.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y+1, Player.transform.position.z);

    }
}