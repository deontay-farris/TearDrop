using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class SoftMove
{
    private int Speed;
    Rigidbody playerRigid;
    Vector3 vec;
    private bool walking;
    private Vector3 move;
    private float speeddo = 200f;
    private float mover;
    private float mohor;
    private Animator ani;
    Transform trans;
    private float anisehor;
    private float anisever;


    //public enum ovestate { w, s, a, d,wd,wa,desta}
    //private int Movestate;

    // class constuct grabs a obj ref to the rigid body
    public SoftMove(ref Rigidbody playerRigid, ref Animator ani, ref Transform trans)
    {
        this.trans = trans;
        this.playerRigid = playerRigid;
        this.ani = ani;
        
        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

    }
    /// <summary>
    /// takes the propoesed move state(int) and sends it to a switch
    /// </summary>
    /// <param name="Movestate"></param>
    public void Move(int movestate)
    {
        mover = Input.GetAxis("Vertical") * Time.deltaTime;
        mohor = Input.GetAxis("Horizontal") * Time.deltaTime;
       // move.z = Input.GetAxis("Vertical") * Time.deltaTime;
       // move.x = Input.GetAxis("Horizontal") * Time.deltaTime;

        this.anisehor = Input.GetAxis("Horizontal");
        this.anisever = Input.GetAxis("Vertical") ;
        //anisever = Mathf.Clamp(anisever, -1f, 1f);
       // anisehor = Mathf.Clamp(anisehor, -1f, 1f);

        // mover = Mathf.Clamp(mover, -1f, 1f);
        // mohor = Mathf.Clamp(mohor, -1f, 1f);
        //////
        //SoftAdjust();\\ //solution to the fast animation found. disregard for now and continue work on the next phase.
        /////////
        ani.SetFloat("softgo", anisever);
        ani.SetFloat("softgohor", anisehor);

        //move = Vector3.Lerp(move, move, 1f);
        //move 
        //Vector3.ClampMagnitude(move, 1f*5);
        //trans.position = move;
        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), playerRigid.velocity.y, Input.GetAxis("Vertical"));
        // if (Input.GetKey("up"))
        // {

        // Speed = 200;
        //  ani.speed = 4.0f;
        //  Debug.Log("shift pressed");
        // }
        //else { ani.speed = 0.3f;  Speed = 0; Debug.Log("value returned to zero"); }

        switch (movestate)
        {
            case 0://w

                trans.Translate(mohor, 0,mover);
                
                this.walking = true;
                //ani.SetBool("walk", this.walking);

                 break;
            case 1://a
                //playerRigid.velocity = new Vector3(Input.GetAxis("Horizontal") - Speed, playerRigid.velocity.y, playerRigid.velocity.z) ;
                trans.Translate(mohor, 0, mover);

               // ani.SetBool("walk", this.walking = false);
                break;
            case 2://s
                trans.Translate(mohor, 0, mover);

                break;
            case 3://d
                //playerRigid.velocity = new Vector3(playerRigid.velocity.x , playerRigid.velocity.y, Input.GetAxis("Horizontal")) * Time.deltaTime;
                trans.Translate(mohor, 0, mover);
                break;
            case 4:
                trans.Translate(0, 0, 0);
                Debug.Log("4");
                break;
            case 5:
                //test(1.0f);
                break;
            default:

                //ani.SetBool("walk", this.walking = false);
                Debug.Log("not moving sir");
              //  ani.speed = 0.3f;
                
                break;
               
        }
        
    }
    private void SoftAdjust()
    {
        if (anisever == 1.0f && anisehor == 1.0f)
        {
            anisever = 0.5f; anisehor = 0.5f;
        }

    }


}
