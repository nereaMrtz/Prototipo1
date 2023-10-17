using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_UI : MonoBehaviour
{
    [SerializeField] PJ_Movement pj;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pj.GetFlowers().Count != 0)
        {
           // pj.GetFlowers()[0].
        }
    }
}
