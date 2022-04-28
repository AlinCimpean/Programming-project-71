using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SessionEndToggles : MonoBehaviour
{

    public GameObject ToggleYes;
    public GameObject ToggleNo;
    public Text timerText;
    public Text completionText;

    public GameObject ActiveScreen;
    public GameObject NextScreen;
    public GameObject ReturnScreen;
    public GameObject ResetMonitor3;
    public GameObject prepareMonitor3;

    // Start is called before the first frame update
    public void EndSession()
    {
        if (ToggleYes.GetComponent<Toggle>().isOn == true)
        {
            ActiveScreen.SetActive(false);
            NextScreen.SetActive(true);
            ResetMonitor3.SetActive(false);
            prepareMonitor3.SetActive(true);
            timerText.enabled = false;
            completionText.enabled = true;

        }
        else if (ToggleNo.GetComponent<Toggle>().isOn == true)
        {
            ActiveScreen.SetActive(false);
            ReturnScreen.SetActive(true);
        }
    }

    
}
