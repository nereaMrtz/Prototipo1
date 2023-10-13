using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PJ_Movement : MonoBehaviour
{
    public CharacterController _controller;
    public float _speed = 10;
    public float _rotationSpeed = 180;

    private Vector3 rotation;

    List<Flower> flowers;

    public void Update()
    {
        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);

        Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
        move = this.transform.TransformDirection(move);
        move += Physics.gravity;
        _controller.Move(move * _speed);
        this.transform.Rotate(this.rotation);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "flower")
        {
             //Debug.Log("colisionando con flor");
            if (Input.GetKey(KeyCode.E))
            {
                flowers.Add(other.gameObject.GetComponent<Flower>());
                Debug.Log("guardo flor azul");
            }
        }
    }
}