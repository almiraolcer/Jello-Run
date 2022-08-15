using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScale : MonoBehaviour

{

    public GameObject cube;
    private Vector3 _scaleChange = new Vector3(0.0015f, 0.0015f, 0.0015f);

    void LateUpdate()
    {
     cube.transform.localScale -= _scaleChange;   

     if(cube.transform.localScale.x <= 0f ){
        cube.SetActive(false);
        FindObjectOfType<GameManager>().EndGame();
     }

    }

      void OnTriggerEnter(Collider other){
        if(other.CompareTag("Diamond")){
            cube.transform.localScale += new Vector3(0.6f, 0.6f, 0.6f);
            Destroy(other.gameObject);
        }
        }
    
        private void OnCollisionEnter(Collision col){
        if (col.gameObject.CompareTag("Finishline")){
              _scaleChange = new Vector3(0f, 0f, 0f);
            }
        }
        
    
}
