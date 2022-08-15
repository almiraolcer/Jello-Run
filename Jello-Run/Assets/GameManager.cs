using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded=false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;

  public void EndGame()
  {

    if(gameHasEnded == false){

        gameHasEnded=true;
        Debug.Log("GAME OVER");
        Invoke("Restart", restartDelay);
    }
  }

  void Restart(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void CompleteLevel(){
    completeLevelUI.SetActive(true);
    Debug.Log("LEVEL WON!");
  }
}
