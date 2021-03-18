using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour
{
    public string teksts;
    public string vecums; 
    public GameObject vardaIevadesL;
    public GameObject tekstaAttelosana;
    public GameObject vecumaIevadesL;
    public void uzglabaTekstu()
    {
        teksts = vardaIevadesL.GetComponent<Text>().text;
        vecums = vecumaIevadesL.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = teksts.ToUpper() + " ir "+ vecums.ToUpper() + " gadus veca/vecs!";
    }

}
