using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody rigidbody;
    public int jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            rigidbody.AddForce(
                0,
                jumpForce * Time.deltaTime,
                0
            );

            Material mat = GetComponent<Renderer>().material;
            rigidbody.GetComponent<Renderer>().material = GetComponent<Renderer>().material;
        }
    }
}
