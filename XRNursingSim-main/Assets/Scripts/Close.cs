using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    public GameObject txt;

    public void FixedUpdate()
    {
        close();
    }
    public void close(){
        Debug.Log("Close");
        txt.SetActive(false);
    }
}
