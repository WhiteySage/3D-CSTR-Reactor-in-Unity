using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dssaads : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
      
        Destroy(other.gameObject);
        Debug.Log(other.gameObject);
     
    }
}
