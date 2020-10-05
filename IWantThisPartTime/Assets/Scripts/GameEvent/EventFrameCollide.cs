using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventFrameCollide : MonoBehaviour
{
    public PlayerController player;

    private void OnCollisionEnter(Collision other)
    {
        player.enabled = false;
        FindObjectOfType<GameManager>().EndGame();
    }
}
