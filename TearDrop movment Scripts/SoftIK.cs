using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftIK 
{
    private Animator ani;
    private Transform gunR;
    private Transform gunL;
    private Transform c3;
    private Transform cg;
    private Transform cd;
    private AvatarIKGoal AvatarIKGoal;
    private GameObject Righthold;
    private GameObject Lefthold;

    public Vector3 offset;
    public Transform Target;
    public SoftIK(ref Animator ani, Vector3 offset, ref Transform target)
    {

       this.Righthold = Righthold = GameObject.Find("Righthold");
        this.Lefthold = Lefthold = GameObject.Find("Lefthold");
        this.ani = ani;
        this.offset = offset;
        this.Target = target;
        //public var temp = Righthold.transform;
        
    }
    public void softLook()
    {
       //.Debug.Log(temp);
        OnAnimatorIK();
    }
    void OnAnimatorIK()
    {
        ani.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1f);
        ani.SetIKPositionWeight(AvatarIKGoal.RightHand, 1f);

        ani.SetIKPosition(AvatarIKGoal.LeftHand, Lefthold.transform.position);
        ani.SetIKPosition(AvatarIKGoal.RightHand, Righthold.transform.position);





    }
}
