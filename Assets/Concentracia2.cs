using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Concentracia2 : MonoBehaviour {
    public float concentracia1 = 15;
    public  static float concentracia2 = 10;
    public float concentracia3;
    public Slider sl;
    public Text uu;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        concentracia3 = concentracia1 * sl.value + concentracia2 * sl.value;

        uu.text = "" + Mathf.Floor(concentracia2 * sl.value);
     
    }
}
