using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveScript : MonoBehaviour {

    public GameObject valve;
    public static byte speed = 5;
    public static byte maxHeight = 35;
    public float rightHeight = -1f * maxHeight / 2; 

    public void setRightHeight(float percent)
    {
        Debug.Log("123");
        rightHeight = -1 * (maxHeight * percent);

    }

    private void FixedUpdate()
    {
        
        if (valve.transform.localPosition.y != rightHeight && valve.transform.localPosition.y < 0 && valve.transform.localPosition.y > -1 * maxHeight) 
        {
            if(valve.transform.localPosition.y > rightHeight)
            {
                valve.transform.localPosition -= new Vector3(0, speed * Time.deltaTime,0);
            } else
            {
                valve.transform.localPosition += new Vector3(0, speed * Time.deltaTime, 0);
            }

           
            }
        }
    }
 
