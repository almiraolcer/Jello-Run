using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class CubeDirections : MonoBehaviour  
{  
     Rigidbody m_Rigidbody;
     
    // Start is called before the first frame update  
    void Start()  
    {  
          m_Rigidbody = GetComponent<Rigidbody>();
    }  
  
    // Update is called once per frame  
    void Update()  
    {  
            
        if (Input.GetKey(KeyCode.LeftArrow))  
        {  
            this.transform.Translate(Vector3.left * Time.deltaTime * 5f);  
        }  
        
        if (Input.GetKey(KeyCode.RightArrow))  
        {  
            this.transform.Translate(Vector3.right * Time.deltaTime * 5f );  
        }  

        if(m_Rigidbody.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
  
    }  
}  