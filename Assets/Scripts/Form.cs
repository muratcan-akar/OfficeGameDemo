using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Form : MonoBehaviour
{
    public Gorev gorev;
    public GameObject Tik1, Tik2, Tik3, Tik4, Tik5, Tik6;
    // Start is called before the first frame update
    void Start()
    {
        Tik1.SetActive(false);
        Tik2.SetActive(false); 
        Tik3.SetActive(false); 
        Tik4.SetActive(false); 
        Tik5.SetActive(false); 
        Tik6.SetActive(false);
    }
    public void buton1()
    {
        Tik2.SetActive(false);
        Tik1.SetActive(true);
    }
    public void buton2()
    {
        Tik1.SetActive(false);
        Tik2.SetActive(true);
    }
    public void buton3()
    {
        Tik4.SetActive(false);
        Tik3.SetActive(true);
    }
    public void buton4()
    {
        Tik4.SetActive(true);
        Tik3.SetActive(false);
    }
    public void buton5()
    {
        Tik6.SetActive(false);
        Tik5.SetActive(true);
    }
    public void buton6()
    {
        Tik6.SetActive(true);
        Tik5.SetActive(false);
    }
    public void BitirmeButonu()
    {
        gorev.Gorev3.SetActive(true);
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
