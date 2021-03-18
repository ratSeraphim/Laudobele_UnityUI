using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KursorsUzAttela : MonoBehaviour
{
    public AudioSource skanasAvots;
    public AudioClip skanaKoAtskanot;

    public void uzbiditsuzAttela()
    {
        skanasAvots.PlayOneShot(skanaKoAtskanot);
    }
    public void kursorsNostNoAttela()
    {
        skanasAvots.Stop();
    }
}
