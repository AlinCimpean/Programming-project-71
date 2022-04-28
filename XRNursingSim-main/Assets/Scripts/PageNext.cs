using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageNext : MonoBehaviour
{
    public GameObject ActiveScreen;
    public GameObject NextScreen;

    public void StartSession()
    {
        ActiveScreen.SetActive(false);
        NextScreen.SetActive(true);
       
    }

}
