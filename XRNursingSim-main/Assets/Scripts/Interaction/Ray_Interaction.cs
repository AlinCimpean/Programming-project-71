using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Ray, UI display, random display
/// </summary>
public class Ray_Interaction : MonoBehaviour
{
    /// <summary>
    /// Text display content
    /// </summary>
    public GameObject ShowImg, Blood_Pressure, Thermometer;
    /// <summary>
    /// high blood pressure
    /// </summary>
    public Text HightPressure,LowPressure;
    /// <summary>
    /// body temperature
    /// </summary>
    public Text Blood;
    /// <summary>
    /// camera that emits rays
    /// </summary>
    public Camera Camer;
    public Button Exit;
    public WebBroswerPage ContinueButton;
    public WebBroswerPage ContinueButton2;
    public WebBroswerPage ContinueButton3;
    public WebBroswerPage ContinueButton4;
    public WebBroswerPage ContinueButton5;
    public WebBroswerPage ContinueButton6;
    public WebBroswerPage ContinueButton7;

    void Start()
    {
        Exit.onClick.AddListener(() =>
        {
            HightPressure.text = "";
            LowPressure.text = "";
            Blood.text = "";
            Blood_Pressure.SetActive(false);
            Thermometer.SetActive(false);
            ShowImg.SetActive(false);
        });
    }

    void Update()
    {
        RayToInteraction();
    }
    /// <summary>
    /// Interactive display content
    /// </summary>
    public void RayToInteraction() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camer.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.gameObject.tag.Equals("Pressure"))
                {
                 
                    ShowImg.SetActive(true);
                    Blood_Pressure.SetActive(true);
                    HightPressure.text = RangeCount(90,139).ToString()+"  mmHg";
                    LowPressure.text = RangeCount(60, 89).ToString()+"  mmHg";
                }
                if (hit.collider.gameObject.tag.Equals("Thermometer"))
                {
                    ShowImg.SetActive(true);
                    Thermometer.SetActive(true);
                    Blood.text = RangeCount(36,40).ToString()+"  ¡æ";
                }
                if (hit.collider.gameObject.tag.Equals("ContinueButton"))
                {
                    ContinueButton.buttonPressed();
                }
                if (hit.collider.gameObject.tag.Equals("ContinueButton2"))
                {
                    ContinueButton2.buttonPressed();
                }
                if (hit.collider.gameObject.tag.Equals("ContinueButton3"))
                {
                    ContinueButton3.buttonPressed();
                }
                if (hit.collider.gameObject.tag.Equals("ContinueButton4"))
                {
                    ContinueButton4.buttonPressed();
                }
                if (hit.collider.gameObject.tag.Equals("ContinueButton5"))
                {
                    ContinueButton5.buttonPressed();
                }
                if (hit.collider.gameObject.tag.Equals("ContinueButton6"))
                {
                    ContinueButton6.buttonPressed();
                }
                if (hit.collider.gameObject.tag.Equals("ContinueButton7"))
                {
                    ContinueButton7.buttonPressed();
                }
            }
        }
    }
    /// <summary>
    /// random body temperature
    ///// High pressure range: 90-139 Low pressure range 60-89
    ///// </summary>
    ///// <returns></returns>
    //public float RangeCount(float low,float hight)
    //{
    //    var FloatCount=  Random.Range(low, hight);
    //    return FloatCount;
    //}


    public int RangeCount(int low, int hight) 
    {
        var FloatCount = Random.Range(low, hight);
        return FloatCount;
    }



}
