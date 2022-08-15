using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeForward : MonoBehaviour
{
 public float speed = 5f;

 public GameManager GameManager;

public void Update()
{
    transform.position += transform.forward * (speed * Time.deltaTime);
}


     private void OnCollisionEnter(Collision col){
        if (col.gameObject.CompareTag("Finishline")){
             Invoke("stopMovement", 1);
             GameManager.CompleteLevel();
            }
        }

    private void stopMovement(){
        gameObject.SetActive(false);
        
    }
     }

