using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCollectible : MonoBehaviour
{
    public Rigidbody rigidbody;
    public int incrementTrampolineScore;
    public int incrementBallScore;
    public int incrementFrameScore;

    private int playerScore = 0;
    public Text playerScoreText;

    private void Start()
    {
        playerScoreText.gameObject.SetActive(false);
    }

    public int GetPlayerScore()
    {
        return playerScore;
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerScore(other);
    }

    public void PlayerScore(Collider other)
    {
        if (other.gameObject.CompareTag("Trampoline")) {
            playerScoreText.text = "+" + incrementTrampolineScore.ToString();
            playerScoreText.gameObject.SetActive(true);
            playerScore += incrementTrampolineScore;
        }
        else if (other.gameObject.CompareTag("Ball") &&
        other.GetComponent<Renderer>().material.name.Replace("(Instance)","").Trim() ==
        rigidbody.GetComponent<Renderer>().material.name.Replace("(Instance)","").Trim()) {
            playerScoreText.text = "+" + incrementBallScore.ToString();
            playerScoreText.gameObject.SetActive(true);
            playerScore += incrementBallScore;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("ScoreFrame")) {
            playerScoreText.text = "+" + incrementFrameScore.ToString();
            playerScoreText.gameObject.SetActive(true);
            playerScore += incrementFrameScore;
        }
    }
}
