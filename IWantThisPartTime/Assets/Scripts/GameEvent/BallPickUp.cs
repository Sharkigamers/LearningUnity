using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPickUp : MonoBehaviour
{
    public Rigidbody rigidbody;
    public PlayerController player;
    public int verticalSpeedEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (GetComponent<Renderer>().material.name.Replace("(Instance)","").Trim() ==
        other.GetComponent<Renderer>().material.name.Replace("(Instance)","").Trim()) {
            gameObject.SetActive(false);
            rigidbody.AddForce(Vector3.forward * verticalSpeedEffect * Time.deltaTime);
        } else {
            player.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
