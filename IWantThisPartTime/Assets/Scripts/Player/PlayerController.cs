using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float horizontalForce;
    public float verticalForce;
    public float gravityForce;
    public List<Material> colorMaterial;

    public bool move = true;

    private float previousPlayerY = 0;
    private bool onGround = true;

    private void Start()
    {
    }

    private void FixedUpdate()
    {
        if (move) {
            PlayerMovement();
            moreGravityEffect();
        }
    }

    void PlayerMovement()
    {
        float verticalMove =  Input.GetAxis("Horizontal");

        rigidbody.AddForce(
            verticalMove * horizontalForce * Time.deltaTime,
            0,
            0,
            ForceMode.VelocityChange
        );

        rigidbody.AddForce(
            Vector3.forward * verticalForce * Time.deltaTime
        );
        
        if (rigidbody.position.y < -0.1)
            FindObjectOfType<GameManager>().EndGame();
    }

    void moreGravityEffect()
    {
        float playerY = rigidbody.transform.position.y;

        if (!onGround && previousPlayerY > playerY) {
            rigidbody.AddForce(
                0,
                gravityForce * Time.deltaTime,
                0
            );
        }

        previousPlayerY = playerY;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
            onGround = true;
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
            onGround = false;
    }
}
