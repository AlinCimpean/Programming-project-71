using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
 private float totaltime1 = 360;
    public Text countdown1text;
 
	// Use this for initialization
	void Start () {
 
        countdown1text.text = string.Format("{0:D2}:{1:D2}",
            (int)totaltime1 / 60, (int)totaltime1 % 60);
       StartCoroutine(Count_down());
    }
    private IEnumerator Count_down() {
        while (totaltime1 > 0)
        {
 
            yield return new WaitForSeconds(1.0f);
            totaltime1--;
            countdown1text.text = string.Format("{0:D2}:{1:D2}",
          (int)totaltime1 / 60, (int)totaltime1 % 60);
        }
}
}
