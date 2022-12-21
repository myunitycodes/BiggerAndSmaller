using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public partial class Player : MonoBehaviour
{
    [SerializeField] int levelNumber;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainMenuPanel=GameObject.FindGameObjectWithTag("MainMenuPanel").gameObject;
       
    }

    private void FixedUpdate()
    {

        Movement();

        CurveMovement();

        Rotate();
    }




 


   







}
