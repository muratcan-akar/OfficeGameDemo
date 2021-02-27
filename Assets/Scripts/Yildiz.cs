using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yildiz : MonoBehaviour
{
    public Gorev GorevKodu;
    public AudioSource SesYoneticisi;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SesYoneticisi.Play();
            Destroy(this.gameObject);
            GorevKodu.AlinanYildizSayisi++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
