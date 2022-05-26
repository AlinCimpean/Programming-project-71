using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public GameObject txt;

    public void open(){
        Debug.Log("Active");
        txt.SetActive(true);
    }
}
