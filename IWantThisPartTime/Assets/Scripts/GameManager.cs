using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay;
    public GameObject completeLevelUi;
    public GameObject dieEventUi;
    public PlayerController player;

    private bool gameHasEnded = false;
    
    public void CompleteLevel()
    {
        player.enabled = false;
        completeLevelUi.SetActive(true);
    }
    public void EndGame()
    {
        if (!gameHasEnded) {
            gameHasEnded = true;
            dieEventUi.SetActive(true);

            Invoke("GameRestart", restartDelay);
        }
    }

    void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
