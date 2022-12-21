using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public partial class Player
{
    IEnumerator CoRotate(InputAction.CallbackContext contex)
    {
        if (contex.ReadValue<Vector2>().x > 0)
        {
            rotateAngle = Mathf.Lerp(rotateAngle, 80, 2 * Time.deltaTime);

            Debug.Log(" x > 0  ");
        }
        if (contex.ReadValue<Vector2>().x < 0)
        {
            rotateAngle = Mathf.Lerp(rotateAngle, -80, Time.deltaTime);
            Debug.Log(" x < 0  ");
        }

        rotateAngle = Mathf.Clamp(rotateAngle, -80, 80);

        yield return null;
    }

}
