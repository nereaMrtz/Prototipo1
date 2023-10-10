using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJ_Movement : MonoBehaviour
{
    CharacterController cc;
    Animator anim;

    [SerializeField] float speed = 6f;
    float jumpSpeed = 8f;
    float gravity = 20f;
    private Vector3 move = Vector3.zero;

    Vector3 isMoving = Vector3.zero;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //Comprobar si se mueve para playAnim
    
        if (isMoving != move)
        {
            anim.SetTrigger("Walking");
        }


       
        cc.Move(move * Time.deltaTime * speed);
       // transform.position.z = move.z;
       isMoving = move;
    }
}
