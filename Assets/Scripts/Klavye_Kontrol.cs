using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klavye_Kontrol : MonoBehaviour
{
    public Transform Kamera;
    public Transform Player;
    public float Yatay;
     public float Dikey;
    public float YurumeHizi;
    

    void Start()
    {
        
    }

    void FixedUpdate()
    {       
        Yatay = Input.GetAxisRaw("Horizontal")*YurumeHizi;
         Dikey = Input.GetAxisRaw("Vertical")*YurumeHizi;
        transform.Translate(Yatay * Time.deltaTime, 0, Dikey * Time.deltaTime);
        Kamera.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y+1, Player.transform.position.z);

    }
}