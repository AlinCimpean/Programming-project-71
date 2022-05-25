using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Active : MonoBehaviour
{
    public GameObject txt;

    public void open(){
        Debug.Log("Active");
        txt.SetActive(true);
    }
}
