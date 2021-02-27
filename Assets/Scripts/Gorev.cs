using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gorev : MonoBehaviour
{
    public Animator KapiAnimator;
    public Animator KirmıziButon;
    public GameObject Gorev1, Gorev2, Gorev3;
    public GameObject Form;
    
     public int AlinanYildizSayisi;
    // Start is called before the first frame update
    void Start()
    {
        Gorev1.SetActive(false);
        Gorev2.SetActive(false);
        Gorev3.SetActive(false);
        Form.SetActive(false);
    }
    


    public void İlkGörevButonu()
    {
        KapiAnimator.SetBool("buton", true);
        Gorev1.SetActive(true);
        KirmıziButon.SetBool("Kbuton",true);
    }
    public void SonGorev()
    {
        Form.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AlinanYildizSayisi == 4)
            {
                Gorev2.SetActive(true);
        } 
    }
}
