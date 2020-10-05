using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Transform ground;
    public Vector3 cameraOffset;

    private void Update()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        Vector3 cameraPlayer = new Vector3(0, 0, player.position.z);
        Vector3 cameraGround = new Vector3(ground.position.x, 0, 0);

        transform.position = cameraPlayer + cameraOffset;
    }
}
