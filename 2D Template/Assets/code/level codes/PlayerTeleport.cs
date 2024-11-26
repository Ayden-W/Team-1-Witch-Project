using UnityEngine;
using System.Threading;
using JetBrains.Annotations;
using System.Collections;
using System;

public class PlayerTeleport : MonoBehaviour
{
    public float waitTimeSeconds;
    private GameObject currentTeleporter;
    public bool canTeleport = true;

    void Update()
    {
   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
            if (canTeleport == true)
            {
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
                StartCoroutine(waitTime());
            }

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
           
        }
    }

    //invoke(wait) to fix code




    IEnumerator waitTime()
    {
        canTeleport = false;
        yield return new WaitForSeconds(waitTimeSeconds);
        canTeleport = true;
    }

}