using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConcVihoda : MonoBehaviour {
    public float concentracia1 = 15;
    public float concentracia2 = 10;
    public float concentracia3;
    public Slider sl;
    public Text oo;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        concentracia3 = concentracia1 * sl.value + concentracia2 * sl.value;
        oo.text = "" + concentracia3 * sl.value;

    }
}
