using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class gemfloat : MonoBehaviour
{


    public float animDuration;
    public Ease animEase;


    void Start()
    {
        gameObject.transform
        .DOMoveY(2f,animDuration)
        .SetEase(animEase)
        .SetLoops(-1,LoopType.Yoyo);

    }

}
