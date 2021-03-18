using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour
{
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
   
}
