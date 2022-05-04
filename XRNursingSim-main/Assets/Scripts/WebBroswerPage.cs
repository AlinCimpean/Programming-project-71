using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebBroswerPage : MonoBehaviour
{
    public List<GameObject> toHide; //List of gameobjects to hide when this.button is clicked.
    public List<GameObject> toShow; //List of gameobjects to show when this.button is clicked.

    public void FixedUpdate()
    {
        //debug testing

        if (Input.GetKey(KeyCode.G))
        {
            Debug.Log("G pressed");
            buttonPressed();
        }
    }
    public void buttonPressed()
    {
        Debug.Log("Button Pressed run");

        //Loop though and hide the gameobjects in toHide List.
        for (int i = 0; i < toHide.Count; i++)
        {
            Debug.Log("set active no." + i);
            toHide[i].SetActive(false);
        }

        //Loop though and show the gameobjects in toShow List.
        for (int i = 0; i < toShow.Count; i++)
        {
            toShow[i].SetActive(true);
        }

    }
}
