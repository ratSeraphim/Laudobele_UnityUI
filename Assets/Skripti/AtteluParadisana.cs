using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour
{
    public GameObject krekli;
    public GameObject bikses;
    public GameObject kurpes;
    
    public GameObject mainigaisAttels1;
    public Sprite[] atteluMasivs;

    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
        {
            Debug.Log("Sieviete");
            mainigaisAttels1.GetComponent<Image>().sprite = atteluMasivs[0];
        }
        if (skaitlis == 1)
        {
            Debug.Log("Vīrietis");
            mainigaisAttels1.GetComponent<Image>().sprite = atteluMasivs[1];
        }
    }
    public void krekliAttelosana(bool vertiba)
    {
        krekli.SetActive(vertiba);
    }
    public void biksesAttelosana(bool vertiba)
    {
        bikses.SetActive(vertiba);
    }
    
    public void kurpesAttelosana(bool vertiba)
    {
        kurpes.SetActive(vertiba);
    }
   
}
