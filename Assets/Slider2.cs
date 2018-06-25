using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider2 : MonoBehaviour
{
    public Slider sl;
    public Text ii;
    public Text yy;
    public Text qq;
    public float r = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
        yy.text = Mathf.Floor(Script.poweredenicazasecunduveshestvo2 - (sl.value * (Script.poweredenicazasecunduveshestvo2))) + "";
        ii.text = Mathf.Floor(Script.poweredenicazasecunduveshestvo1 + (sl.value * (Script.poweredenicazasecunduveshestvo1))) + "";
        qq.text = 100 - Mathf.Floor(((Script.poweredenicazasecunduveshestvo2 - (sl.value * (Script.poweredenicazasecunduveshestvo2))) / +(Script.poweredenicazasecunduveshestvo1 + (sl.value * (Script.poweredenicazasecunduveshestvo1))))*100 ) + "%";





    }
}


