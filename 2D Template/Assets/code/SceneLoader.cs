using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;
<<<<<<< HEAD
    public bool canChangeScenes;
=======
    public bool canChangeScenes = true;
>>>>>>> 0a2b88fc8d4593096f4c1e338fea74976252634f
    public float waitTimeSeconds;
    private GameObject Door;
    
    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
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
   

