using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform cube;
    public Text scoreText;


    // Update is called once per frame
    void Update()
    {
        scoreText.text=(cube.transform.localScale.magnitude * 10 ).ToString("0");
    }
}
