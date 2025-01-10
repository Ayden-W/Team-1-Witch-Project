using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpBag : MonoBehaviour
{

    private GameObject ActiveBag;
    
    public static int bagsCollected = 0;
    public static int transferedBags;


   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Active Bag"))
        {
            ActiveBag = collision.gameObject;
            bagsCollected += 1;
            transferedBags = bagsCollected;
            Debug.Log(bagsCollected);
            Destroy(ActiveBag);
       
        }
    }
    






   

}
