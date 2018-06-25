using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

	


    public Light svet1;
    public Light svet2;
    public Light svet3;
    public Light svet4;
    public Light svet5;
    public Light svet6;

    // Use this for initialization
    void Start()
    {
        svet1.enabled = false;
        svet2.enabled = false;
        svet3.enabled = false;
        svet4.enabled = false;
        svet5.enabled = false;
        svet6.enabled = false;




        // Update is called once per frame

    }
    private void Update()
    {


        if (((10 * Script.p1) > 8)&& Script.w )
        {
            svet1.enabled = false;
            svet2.enabled = false;
            svet3.enabled = true;
            svet4.enabled = true;
            svet5.enabled = true;
            svet6.enabled = true;
        }
        else
        {
            if (((10 * Script.p1) < 8) && ((10 * Script.p1) >1) && Script.w)
            {
                svet1.enabled = true;
                svet2.enabled = true;
                svet3.enabled = true;
                svet4.enabled = true;
                svet5.enabled = false;
                svet6.enabled = false;
            }

        }
    }
}

