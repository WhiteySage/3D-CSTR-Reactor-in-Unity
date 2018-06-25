using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kilkistProdukta : MonoBehaviour {

    // Use this for initialization
    public Text bb;
    public static float kilkistprodukta = 0;

    void OnTriggerEnter(Collider other)
    {

        kilkistprodukta++;
        Debug.Log(kilkistprodukta);
        bb.text = "" + (kilkistprodukta*3)/1000;
    }
}
