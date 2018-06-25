using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ыввыввввв : MonoBehaviour {
    public GameObject prefab3;

     
    public Collision ttt;
    private void Start()
    {
    
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "1(Clone)" || collision.gameObject.name == "2(Clone)")
        {
            
            ttt = collision;

            StartCoroutine("DoCheck");
        }
       
    }
     

    IEnumerator DoCheck()
    {
        Collision ggy;
        ggy = ttt;
        yield return new WaitForSeconds(2f);

        Instantiate(prefab3, ggy.gameObject.transform.position, Quaternion.AngleAxis(angle: 30, axis: Vector3.left));
      
         ggy.gameObject.SetActive(false);


    }

    }
 
