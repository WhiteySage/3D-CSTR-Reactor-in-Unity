using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rashod : MonoBehaviour {
    public float rashod1;
    public float rashod2;
    public float jj;
   
    public bool k = false;
    public Text textrash;
	// Use this for initialization
	void Start () {
     
        
       
	}
	
	// Update is called once per frame
	void Update () {
        rashod1 = EE.rashodw;
        rashod2 = VV.rashodi;
        jj = (rashod1+1) / (rashod2+1);
        textrash.text = "" + jj;
    }
}
