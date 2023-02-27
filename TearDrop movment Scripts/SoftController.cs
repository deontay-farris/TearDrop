using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class SoftController : MonoBehaviour
{
    
    private Rigidbody playerRigid;
    private SoftMove movem;
    private Transform trans;
    private float speed = 52f;
    private Animator ani;
    private bool go = true;
    private CapsuleCollider phym;
    float movespeed;






    void Start()
    {
        
        phym = GetComponent<CapsuleCollider>();
        ani = GetComponent<Animator>();
        playerRigid = GetComponent<Rigidbody>();
        trans = GetComponent<Transform>();
        playerRigid.freezeRotation = true;
        movem = new SoftMove(ref playerRigid, ref ani, ref trans); ;

        
        
    }
    
    void Update()
    {
        charmovement();

    }
    private void FixedUpdate()
    {

        
    }
    //LOOKS for user input and decides which  one to use 
    private void charmovement()
    {
        
        //movespeed = Input.GetAxis("Vertical") * Time.deltaTime;

        if (Input.GetKey("w"))
        {
            movem.Move(0);
            //phym.material.dynamicFriction = 0;
            
            //trans.Translate (0,0,movespeed * 5);
        }
        else
        if (Input.GetKey("a"))
        {
            movem.Move(1);
            //phym.material.dynamicFriction = 0;
        }
        else
             if(Input.GetKey("s"))
        {
            movem.Move(2);
           // phym.material.dynamicFriction = 0;
        }
        else
        if (Input.GetKey("d"))
        {
            movem.Move(3);
           // phym.material.dynamicFriction = 0;
        }
        else
            if (Input.GetKey("w") & Input.GetKey("d"))
        {
            movem.Move(4);
           // phym.material.dynamicFriction = 0;
        }
        else
            if (Input.GetKey("w") & Input.GetKey("a"))
        {
            movem.Move(5);
           // phym.material.dynamicFriction = 0;
        }
        else { movem.Move(6);}
        

    }



}
