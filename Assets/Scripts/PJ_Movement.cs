using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;


public class PJ_Movement : MonoBehaviour
{
    public CharacterController _controller;
    public float _speed = 10;
    public float _rotationSpeed = 180;

    private Vector3 rotation;

    [SerializeField]Inventory_UI inventory;
    List<Flower> flowers = new List<Flower>();
    int flowerCounter = 0;

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
             Debug.Log("colisionando con flor");
            if (Input.GetKey(KeyCode.E))
            {
                flowers.Add(other.gameObject.GetComponent<Flower>().GetFlower());
                //Debug.Log("guardo flor azul");
                Debug.Log(flowers[flowerCounter].GetColor());
                inventory.AddFlowerToInventory(flowers[flowerCounter].GetColor());
                flowerCounter++;
                Destroy(other.gameObject);
            }
        }
    }

    public List<Flower> GetFlowers() { return flowers; }
    public int GetFlowerCounter() {  return flowerCounter; }
}