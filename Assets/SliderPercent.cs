using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderPercent : MonoBehaviour {
    public Slider sl;
    public Text ii;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ii.text = "" + Mathf.Floor( sl.value*100);
       
    }

    
}
