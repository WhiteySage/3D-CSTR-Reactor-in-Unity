using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VV : MonoBehaviour {
    public Text wwww;
    static public float rashodi = 0;
    
    void OnTriggerEnter(Collider other)
    {

        rashodi++;
        
        wwww.text = ""+rashodi/1000 ;

    }

 
}
