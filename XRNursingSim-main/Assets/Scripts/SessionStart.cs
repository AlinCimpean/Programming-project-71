using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SessionStart : MonoBehaviour
{
    public Text timerText;
    private float time = 1200;
    public GameObject ActiveScreen;
    public GameObject NextScreen;
    public GameObject EnableMonitor3;
    public GameObject DisablePlaceholder;

    public void StartSession()
    {
        ActiveScreen.SetActive(false);
        NextScreen.SetActive(true);
        EnableMonitor3.SetActive(true);
        DisablePlaceholder.SetActive(false);
        if (timerText != null)
        {
            time = 1200;
            timerText.text = "Time Left: 1:00:000";
            InvokeRepeating("UpdateTimer", 0.0f, 0.01667f);
        }
    }

    void UpdateTimer()
    {
        if (timerText != null)
        {
            time -= Time.deltaTime;
            string minutes = Mathf.Floor(time / 60).ToString("00");
            string seconds = (time % 60).ToString("00");
            string fraction = ((time * 100) % 100).ToString("000");
            timerText.text = minutes + ":" + seconds + ":" + fraction;
        }
    }
}
