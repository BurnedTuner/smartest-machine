using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : MonoBehaviour
{
    public void TryMove(Vector3 direction)
    {
        if (CanMove(direction))
            Move(direction);
    }

    private bool CanMove(Vector3 direction)
    {
        Vector3 desiredPosition = direction + transform.position;

        foreach (RaycastHit2D hit in Physics2D.RaycastAll(transform.position, direction, 1f))
            if (hit.collider.GetComponent<DefaultBlock>() && hit.collider != GetComponent<Collider2D>())
                return false;

        return true;
    }

    private void Move(Vector3 direction)
    {
        transform.position += direction;
    }
}
