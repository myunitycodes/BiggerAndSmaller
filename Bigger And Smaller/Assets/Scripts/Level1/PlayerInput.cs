using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public partial class Player
{
    bool isTriggeredSwipe;
    public void InputSwipe(InputAction.CallbackContext contex)
    {
        if (contex.started)
        {
            StartCoroutine(CoRotate(contex));
            isTriggeredSwipe = true;// Yeniden Tap edene kadar true kalmali ki Delta==0 durumlarinda hemen ileriye donme eylemi gerceklesmesin.Ileriye donme eylemi ilk dokunusta delta 0 dan farkli olana kadar gerceklessin. 
        }

        if (contex.canceled)
        {
            StopCoroutine(CoRotate(contex));

        }
    }

    public void InputTap(InputAction.CallbackContext contex)
    {
        if (contex.started)
        {
            isMoving = true; isTriggeredSwipe = false;//Yeniden Tap olana kadar true da tutuldu. 
        }
        if (contex.canceled) isMoving = false;
    }
}
