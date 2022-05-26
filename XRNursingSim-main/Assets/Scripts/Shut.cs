using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shut : MonoBehaviour
{
    public GameObject txt;

    public void close(){
        Debug.Log("Close");
        txt.SetActive(false);
    }
}
