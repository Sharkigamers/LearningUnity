using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovingBallController : MonoBehaviour
{
    public GameObject plateform;
    public float moveSpeed;
    public float marginBorder;

    private bool movingRightToLeft = false;

    private void LateUpdate()
    {
        MoveHorizontalyBall();        
    }

    void MoveHorizontalyBall()
    {
        Vector3 plateformScale = plateform.GetComponent<Collider>().bounds.size;
        Vector3 ballScale = GetComponent<Collider>().bounds.size;
        Vector3 newBallPosition = transform.position;

        if (transform.position.x >= plateformScale.x / 2 - ballScale.x / 2 - marginBorder)
            movingRightToLeft = true;
        else if (transform.position.x <= (-plateformScale.x / 2) - (-ballScale.x / 2) - (-marginBorder))
            movingRightToLeft = false;

        if (transform.position.x <= plateformScale.x / 2 - ballScale.x / 2 - marginBorder && !movingRightToLeft) {
            newBallPosition.x += moveSpeed;
            transform.position = newBallPosition;
        } else if (transform.position.x >= (-plateformScale.x / 2) - (-ballScale.x / 2) - (-marginBorder) && movingRightToLeft) {
            newBallPosition.x -= moveSpeed;
            transform.position = newBallPosition;
        }
    }
}
