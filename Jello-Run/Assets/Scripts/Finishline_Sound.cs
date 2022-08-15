using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishline_Sound : MonoBehaviour
{

    [SerializeField]  AudioSource Finishlinesource;
    [SerializeField]  AudioClip  Finishlineclip;

    
    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Cube")){
            Finishlinesource.PlayOneShot(Finishlineclip);
        }
    }

}

