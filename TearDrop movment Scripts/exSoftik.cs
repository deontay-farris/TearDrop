using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Softik : MonoBehaviour
{
    private Animator ani;
    private AvatarIKGoal AvatarIKGoal;
    private GameObject Righthold;
    private GameObject aimhold;

    public Vector3 offset;
    private Transform chest;
    private Transform TarAim;
    private Quaternion lookRotation;
    // Start is called before the first frame update
    void Start()
    {
        //TarAim = GameObject.Find("TarAim").transform;

        ani = GetComponent<Animator>();
        chest = ani.GetBoneTransform(HumanBodyBones.Chest);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        //chest.LookAt(TarAim.transform);
       // chest.rotation = chest.rotation * Quaternion.Euler(offset);
    }
    void OnAnimatorIK()
    {
       // ani.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1f);
       // ani.SetIKPositionWeight(AvatarIKGoal.RightHand, 1f);

        //ani.SetIKPosition(AvatarIKGoal.LeftHand, Lefthold.transform.position);
       // ani.SetIKPosition(AvatarIKGoal.RightHand, Righthold.transform.position);





    }
}
