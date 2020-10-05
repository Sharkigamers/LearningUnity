using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public ScoreCollectible scoreCollectible;
    public Transform player;

    public Text scoreText;

    private int score = 0;

    private void Update()
    {
        scoreText.text = (score + scoreCollectible.GetPlayerScore()).ToString();
    }

    private void FixedUpdate()
    {
        CountScore();
    }

    private void CountScore()
    {
        score = (int)player.position.z;
    }
}
