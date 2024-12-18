using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;
    public bool canChangeScenes;
    public float waitTimeSeconds;
    public GameObject Door;
    
    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
           changeScene();
            Debug.Log("Door");

        }
    }
    IEnumerator waitTime()
    {
        canChangeScenes = false;
        yield return new WaitForSeconds(waitTimeSeconds);
        canChangeScenes = true;
    }

}
   

