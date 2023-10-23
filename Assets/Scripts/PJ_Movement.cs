using System.Collections.Generic;
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

    [SerializeField] public GameObject handFlower1;
    [SerializeField] public GameObject handFlower4;

    [SerializeField]public GameObject potion;

    public bool hasPotion;

    private AudioManager sound;

    Animator anim;

    [SerializeField] GameObject eFlower;

    public void Start()
    {
        anim = GetComponent<Animator>();
        sound = GameObject.FindGameObjectWithTag("AM").GetComponent<AudioManager>();
        hasPotion = false;
    }

    public void Update()
    {
        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);

        Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
        move = this.transform.TransformDirection(move);
        move += Physics.gravity;
        _controller.Move(move * _speed);
        this.transform.Rotate(this.rotation);
        anim.SetBool("isWalking", false);

        if ((Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f) && !sound.grassSteps.isPlaying)
        {
            sound.grassSteps.Play();
            anim.SetBool("isWalking", true);
        }

        else if (Input.GetButtonUp("Horizontal") || Input.GetButtonUp("Vertical"))
        {
            sound.grassSteps.Pause();

        }
        else {  }
    }

        private void OnTriggerStay(Collider other)
    {
        if(other.tag == "flower")
        {

            // Debug.Log("colisionando con flor");
            eFlower.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                eFlower.SetActive(false);
                flowers.Add(other.gameObject.GetComponent<Flower>().GetFlower());
                //Debug.Log("guardo flor azul");
                Debug.Log(flowers[flowerCounter].GetColor());
                inventory.AddFlowerToInventory(flowers[flowerCounter].GetColor());
                flowerCounter++;
                Destroy(other.gameObject);

                sound.pickup.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "flower")
        {
            eFlower.SetActive(false);
        }

    }

    public List<Flower> GetFlowers() { return flowers; }
    public int GetFlowerCounter() {  return flowerCounter; }

    public Inventory_UI GetInventory() { return  inventory; }
}