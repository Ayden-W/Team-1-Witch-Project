using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpBag : MonoBehaviour
{

    private GameObject ActiveBag;
    
    public int bagsCollected = 0;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Active Bag"))
        {
            ActiveBag = collision.gameObject;
            bagsCollected += 1;
            Destroy(ActiveBag);

        }
    }
    






   

}