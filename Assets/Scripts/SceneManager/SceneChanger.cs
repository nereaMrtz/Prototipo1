using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] string sceneName;

    void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene(sceneName);
    }
}
