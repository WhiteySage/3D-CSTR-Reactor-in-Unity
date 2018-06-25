using UnityEngine;
using UnityEngine.UI;

public class Concentracia : MonoBehaviour {
    public float concentracia = 0.1f; //current
    public float concentracia3;
    public float rightConcentration;
    public Slider sl;
    public Text mmm;
    public Text Concentracia1;
    public Text Concentracia2;
    public Image progressbar;
    public GameObject clapan;
    // Use this for initialization
    void Start () {
        rightConcentration = sl.value;
        Concentracia2.text = 0 + "";
    }

    public void changeSlider()
    {
        rightConcentration = sl.value;
        Concentracia2.text = (int) (rightConcentration * 100) + "";

        progressbar.fillAmount = rightConcentration;
        clapan.GetComponent<ValveScript>().setRightHeight(sl.value);
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {

        if (rightConcentration != concentracia)
        {
            if (rightConcentration > concentracia)
            {
                concentracia += 0.01f * Time.deltaTime;
            }
            else
            {
                concentracia -= 0.01f * Time.deltaTime;
            }
        }
        Concentracia1.text = (int)(concentracia * 100) + "";
    }
          //текущ concentracia2*sl.value

} //D += 1 * Time.deltaTime;
