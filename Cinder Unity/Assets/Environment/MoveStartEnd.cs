using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStartEnd : MonoBehaviour
{
    public Transform startPosition;
    public Transform endPosition;
    public float moveSpeed;
    public float currentPos;
    public InteractableTrigger trigger;

    void FixedUpdate()
    {
        if (trigger.getActiveState() && transform.position != endPosition.position)
        {
            currentPos += moveSpeed;
            currentPos = Mathf.Min(currentPos, 1);
            Vector3 newPos = Bezier.bezier2D(
                startPosition.position,
                Vector2.Lerp(startPosition.position, endPosition.position, 0.1f),
                Vector2.Lerp(startPosition.position, endPosition.position, 0.9f),
                endPosition.position,
                currentPos
                );
            transform.position = newPos;

        }
        else if(!trigger.getActiveState() && transform.position != startPosition.position)
        {
            currentPos -= moveSpeed;
            currentPos = Mathf.Max(currentPos, 0);
            Vector3 newPos = Bezier.bezier2D(
                startPosition.position,
                Vector2.Lerp(startPosition.position, endPosition.position, 0.1f),
                Vector2.Lerp(startPosition.position, endPosition.position, 0.9f),
                endPosition.position,
                currentPos
                );
            transform.position = newPos;
        }
    }
}
