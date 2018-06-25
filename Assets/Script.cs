using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{

    public static float poweredenicazasecunduveshestvo1 = 20; // 50 max
    public static float poweredenicazasecunduveshestvo2 = 20; // 50 max
   // public int poweredenicazasecunduveshestvo3 = 5; // 50 max
    public float veshesto1timer = 0;
    public float veshesto2timer = 0;
    public float veshesto3timer = 0;
    public float coef1 = 0;
    public float coef2 = 0;
   // public float coef3 = 0;
    public GameObject prefab;
    public GameObject SpawnPos;
    public GameObject prefab2;
    public GameObject SpawnPos2;
   // public GameObject prefab3;
   // public GameObject SpawnPos3;
    public int i = 0;
    public GameObject cilinder;
    public int maxi = 1000; //3000
    public Slider sl;
    public Slider sl2;
    public float power1 = 1;
    public float power2 = 1;
    //public float power3 = 1;
    public  static bool w;
    public static float p;
    public static float p1;

    public AudioClip din;
    AudioSource audio;
    public Text nnn;


    public void Start()
    {

         

       
        power1 = poweredenicazasecunduveshestvo1 + poweredenicazasecunduveshestvo1 * sl2.value + 1;
        power2 =  poweredenicazasecunduveshestvo2 - poweredenicazasecunduveshestvo2 * sl2.value + 1;

        //  power3 = poweredenicazasecunduveshestvo3;
        coef1 = 1f / ((float)power1);
        coef2 = 1f / ((float)power2);
        // coef3 = 1f / ((float)power3);

       
        
    }

     

    public void Activate()
    {
        w = true;
        audio = GetComponent<AudioSource>();

    }
  

    public void SliderChange()
    {
         


        
        power1 = poweredenicazasecunduveshestvo1 + poweredenicazasecunduveshestvo1 * sl2.value + 1;
        power2 = poweredenicazasecunduveshestvo2 - poweredenicazasecunduveshestvo2 * sl2.value + 1;
        //power3 = (1 - sl.value) * poweredenicazasecunduveshestvo1;
    }

    private void Update()
    {
        
        p1 = sl2.value;

        if (w)
        {
             
            

            coef1 = 1f / ((float)power1);
        coef2 = 1f / ((float)power2);
      //  coef3 = 1f / ((float)power3);

       


            if (i < maxi)
            {

                if (veshesto1timer > 0)
                {
                    veshesto1timer -= Time.deltaTime;

                }
                else
                {
                    Instantiate(prefab, SpawnPos.transform.position, Quaternion.AngleAxis(angle: 300, axis: Vector3.left));
                    veshesto1timer = coef1;
                    i++;
                }

                if (veshesto2timer > 0)
                {
                    veshesto2timer -= Time.deltaTime;
                }
                else
                {
                    Instantiate(prefab2, SpawnPos2.transform.position, Quaternion.AngleAxis(angle: 270, axis: Vector3.left));
                    veshesto2timer = coef2;
                    i++;
                }

                //if (veshesto3timer > 0)
               // {
                //    veshesto3timer -= Time.deltaTime;

               // }
               // else
               // {
                //    Instantiate(prefab3, SpawnPos3.transform.position, Quaternion.AngleAxis(angle: 30, axis: Vector3.left));
                 //   veshesto3timer = coef3;
                 //   i++;
               // }

            }


            Quaternion RotationY = Quaternion.AngleAxis(5, Vector3.up);
            transform.rotation *= RotationY;
        }




    }

    public void CenterMass()
    {

    }


  public  void DeActivate()
    {
        w = false;

       
    }
}





