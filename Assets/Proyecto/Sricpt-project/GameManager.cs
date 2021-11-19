using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 
    public GameObject Player;

   public  void Endgame() 
    {
        Debug.Log("GAME OVER");
        Destroy(Player);
        RestartGame();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Proyecto");
    }
}




