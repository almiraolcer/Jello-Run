using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    [SerializeField]  AudioSource Collectsource;
    [SerializeField]  AudioClip  Collectclip;

    
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Diamond")){
            Collectsource.PlayOneShot(Collectclip);
        }
    }

}