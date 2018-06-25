using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graphswa : MonoBehaviour {

    public bool corot = true;
    public LineRenderer lin1;
    public int shag = 0;
    public Vector3 startpd;
    public bool cdfg;
    public bool onet;
    public TextMesh[] meshd;
    public int fhh;

    // Use this for initialization
    void Start () {
        startpd = lin1.transform.position;

    }
	
	// Update is called once per frame
	void Update () {




        if (!Script.w) {
            corot = true;
            shag = 0;
            lin1.positionCount = 1;
            lin1.transform.position = startpd;
            cdfg = false;
            onet = false;
        }



      
        if (Script.w) {
            if (!onet) { StartCoroutine("DoCheck2"); }
            
            if (cdfg) {
                Debug.Log(Script.w);
                if (shag>=18)  //18
            {
                    lin1.transform.Translate(-1f * Time.deltaTime, 0, 0);
                    fhh = fhh + 1;

                    if (fhh >= 10)
                    {
                        fhh = 0;
                        foreach (TextMesh item in meshd)
                        {
                            bool isConvertible = false;
                            int myInt = 0;
                            isConvertible = int.TryParse(item.text, out myInt);
                            item.text = (myInt + 1).ToString();
                        }
                    }
                }


          //  this.gameObject.transform.Translate(-1*Time.deltaTime,0,0);
            if (corot) {
                Debug.Log("f");
                StartCoroutine("DoCheck");
                corot = false;
            }

            }
        }






    }
    

    IEnumerator DoCheck()
    {
        
        yield return new WaitForSeconds(0.4f); //0.4f
       
        if (Script.w) {
            lin1.positionCount = lin1.positionCount + 1;
            shag++;
            lin1.SetPosition(lin1.positionCount-1, new Vector3(lin1.GetPosition(lin1.positionCount-2).x+0.4f, (Script.p1+1)* (Script.p1 + 1), 0));
            StartCoroutine("DoCheck");

            
        }

    }


    IEnumerator DoCheck2()
    {

        yield return new WaitForSeconds(2f);
        onet = true;
        cdfg = true;

    }
}


