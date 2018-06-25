using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EE : MonoBehaviour {
    public Text wwww;
   public static float rashodw = 0;

    void OnTriggerEnter(Collider other)
    {

        rashodw++;

        wwww.text = "" + rashodw/1000;
    }
}

  
