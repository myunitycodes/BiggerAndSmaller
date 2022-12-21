using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public partial class Player
{
    bool canInput = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "JumpStartPoint")
        {
            canInput = false;
        }

        if (other.tag == "JumpFinishPoint")
        {
            canInput = true;
        }

        if (other.gameObject.tag == "Gem")
        {
            UpdateGemNumberCollider();
        }
        if (other.gameObject.tag == "Finish")
        {
            finishPanel.SetActive(true);
            canInput = false;
            PlayerPrefs.SetInt("Level"+(levelNumber+1),0);//Falce
            PlayerPrefs.SetInt("BtnLevel" + (levelNumber+1),1);//True
        }


    }

}
