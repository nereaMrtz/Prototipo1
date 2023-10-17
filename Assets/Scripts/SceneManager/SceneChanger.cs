using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] string nextSceneName;
    [SerializeField] Transform playerTransform;
    [SerializeField] Transform newSpawn;


    void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene(nextSceneName);
        playerTransform = newSpawn;

        //if (currentSceneName == "Forest") ;
    }
}
