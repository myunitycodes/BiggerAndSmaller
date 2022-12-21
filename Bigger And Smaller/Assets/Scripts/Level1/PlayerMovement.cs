using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public partial class Player
{
    float rotateAngle;
    bool isMoving;


    void Movement()
    {
        if (isMoving && canInput && isTappedStart) rb.MovePosition(rb.position + transform.forward * Time.fixedTime / 100);

    }

    private void Rotate()
    {
        if (canInput && isTappedStart)
        {
            if (!isTriggeredSwipe && isMoving) rotateAngle = Mathf.Lerp(rotateAngle, 0, 3 * Time.fixedDeltaTime);
            rb.MoveRotation(Quaternion.Euler(0, rotateAngle, 0));
        }



    }

}
