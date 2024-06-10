using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ending : MonoBehaviour
{
    public string sceneName;

    // Çarpışma kontrolü
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("aksldmaklwsmd");
        if (other.gameObject.tag=="Player")
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}  
