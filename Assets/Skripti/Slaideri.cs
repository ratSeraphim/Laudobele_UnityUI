using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slaideri : MonoBehaviour
{
    public GameObject mainTels;
    public GameObject slaiderisHoriz;
    public GameObject slaiderisVerti;
    
    public void mainitVertikali()
    {
        float pasreizVertiba2 = slaiderisHoriz.GetComponent<Slider>().value;
        float pasreizVertiba1 = slaiderisVerti.GetComponent<Slider>().value;
        mainTels.transform.localScale = new Vector3(0.5F * pasreizVertiba2, 0.5F * pasreizVertiba1, 0.5F);
    }

}
