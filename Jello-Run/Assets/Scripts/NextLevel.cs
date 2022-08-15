using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
   public void LoadNextLevel(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
}
