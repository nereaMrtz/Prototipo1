using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private static SpawnManager instance;
    void Awake(){
        DontDestroyOnLoad (this);

        if (instance == null) {
            instance = this;
        } 
        
        else {
            DestroyObject(gameObject);
        }
    }
}