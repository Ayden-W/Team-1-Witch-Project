using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;

    private bool canChangeScenes = false;

    public float waitTimeSeconds;
    private GameObject Door;
    //public static Vector2 lastPostion;

    private void Start()
    {
        StartCoroutine(waitTime());
    }

    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //walkedThroughDoor =! walkedThroughDoor;
           // lastPostion = collision.transform.position;
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
   

