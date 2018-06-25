using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clapa : MonoBehaviour {

    public GameObject clapan;
    public Vector3 startpos;
    public Vector3 endpos;
    // Use this for initialization
    void Start () {
        startpos = clapan.transform.position;
       
    }
	
	// Update is called once per frame
	void Update () {
       
        if (clapan.transform.localPosition.y < 0 - 30*Script.p1)
        { clapan.transform.Translate(Vector3.up * Time.deltaTime/5);
            clapan.transform.Rotate(0, 90* Time.deltaTime, 0);
        }


        if (clapan.transform.localPosition.y > -30*Script.p1)
        {
            clapan.transform.Translate(Vector3.down * Time.deltaTime / 5);
            clapan.transform.Rotate(0, -90 * Time.deltaTime, 0);
        }
    }
}
