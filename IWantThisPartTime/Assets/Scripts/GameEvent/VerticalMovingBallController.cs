using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingBallController : MonoBehaviour
{
    public GameObject plateform;
    public float positiveSpeed;
    public float negativeSpeed;
    public int ceiling;

    [SerializeField] int waitingTime;

    private bool moveBottomToTop = true;

    private void LateUpdate()
    {
        CellingContact();
        MoveVerticallyBall();
    }

    private void CellingContact()
    {
        Vector3 plateformScale = plateform.GetComponent<Collider>().bounds.size;

        if (transform.position.y >= plateform.gameObject.transform.position.y + ceiling)
            moveBottomToTop = false;
        else if (transform.position.y <= plateform.gameObject.transform.position.y + plateformScale.y)
            moveBottomToTop = true;
    }

    private void MoveVerticallyBall()
    {
        Vector3 newBallPosition = transform.position;

        if (moveBottomToTop) {
            newBallPosition.y += positiveSpeed;
            transform.position = newBallPosition;
        } else
            newBallPosition.y -= negativeSpeed;
            transform.position = newBallPosition;
    }
}
