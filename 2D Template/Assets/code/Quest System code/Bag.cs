using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour, IItem
{
  

    public void Collect()
    {
       Destroy(gameObject);
    }

   
}


