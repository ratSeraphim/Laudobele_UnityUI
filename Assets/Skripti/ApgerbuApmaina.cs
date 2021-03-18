using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApgerbuApmaina : MonoBehaviour
{

    public GameObject mainigaisAttels1;
    public GameObject mainigaisAttels2;
    public GameObject mainigaisAttels3;
    public GameObject mainigaisAttels4;
    public GameObject mainigaisAttels5;
    public GameObject mainigaisAttels6;
    public Sprite[] atteluMasivs;

    public void apgerbi(int skaitlis)
    {
        if (skaitlis == 0)
        {
            mainigaisAttels1.GetComponent<Image>().sprite = atteluMasivs[0];
            mainigaisAttels1.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
            mainigaisAttels2.GetComponent<Image>().sprite = atteluMasivs[1];
            mainigaisAttels2.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
            mainigaisAttels3.GetComponent<Image>().sprite = atteluMasivs[4];
            mainigaisAttels3.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
            mainigaisAttels4.GetComponent<Image>().sprite = atteluMasivs[5];
            mainigaisAttels4.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
            mainigaisAttels5.GetComponent<Image>().sprite = atteluMasivs[8];
            mainigaisAttels5.transform.localScale = new Vector3(0.6f, 0.5f, 0.0f);
            mainigaisAttels6.GetComponent<Image>().sprite = atteluMasivs[9];
            mainigaisAttels6.transform.localScale = new Vector3(0.6f, 0.5f, 0.0f);
        }
        if (skaitlis == 1)
        {
            mainigaisAttels1.GetComponent<Image>().sprite = atteluMasivs[2];
            mainigaisAttels1.transform.localScale = new Vector3(0.5f, 0.6f, 0.0f);
            mainigaisAttels2.GetComponent<Image>().sprite = atteluMasivs[3];
            mainigaisAttels2.transform.localScale = new Vector3(0.5f, 0.6f, 0.0f);
            mainigaisAttels3.GetComponent<Image>().sprite = atteluMasivs[6];
            mainigaisAttels3.transform.localScale = new Vector3(0.4f, 0.5f, 0.0f);
            mainigaisAttels4.GetComponent<Image>().sprite = atteluMasivs[7];
            mainigaisAttels4.transform.localScale = new Vector3(0.4f, 0.5f, 0.0f);
            mainigaisAttels5.GetComponent<Image>().sprite = atteluMasivs[10];
            mainigaisAttels5.transform.localScale = new Vector3(0.5f, 0.4f, 0.0f);
            mainigaisAttels6.GetComponent<Image>().sprite = atteluMasivs[11];
            mainigaisAttels6.transform.localScale = new Vector3(0.5f, 0.4f, 0.0f);
        }
    }

}
