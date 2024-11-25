using UnityEngine;
using System.Threading;
using JetBrains.Annotations;

public class PlayerTeleport : MonoBehaviour
{
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
                canTeleport = false;
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
    public void CanTeleport()
    {
        canTeleport = true;
    }

}
