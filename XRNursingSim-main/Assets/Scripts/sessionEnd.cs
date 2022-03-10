using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sessionEnd : MonoBehaviour
{
    public Text timerText;
    
    public GameObject ActiveScreen;
    public GameObject NextScreen;
    public GameObject ResetMonitor3;
    public GameObject prepareSession;

    public void StartSession()
    {
        ActiveScreen.SetActive(false);
        NextScreen.SetActive(true);
        ResetMonitor3.SetActive(false);
        prepareSession.SetActive(true);
        if (timerText != null)
        {
            
            timerText.text = "Completed";
            InvokeRepeating("UpdateTimer", 0.0f, 0.01667f);
        }
    }

}